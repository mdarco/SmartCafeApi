using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartCafe.Postgres.DTO;
using SmartCafe.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DAL
{
    public interface IOrdersDal
    {
        // orders
        Task<List<OrderDto>> GetAllOrdersAsync();
        Task<List<OrderDto>> GetFilteredOrdersAsync(OrderFilterDto filter);
        Task<OrderDto> GetOrderAsync(int id);
        Task<OrderDto> CreateOrderAsync(OrderDto order);
        Task<OrderDto> UpdateOrderAsync(OrderDto order);
        void DeleteOrder(int id);

        // order items
        Task<List<OrderItemDto>> GetOrderItemsAsync(int orderId);
        Task<OrderItemDto> AddOrderItemAsync(OrderItemDto orderItem);
        Task<OrderItemDto> UpdateOrderItemAsync(OrderItemDto orderItem);
        Task DeleteOrderItemAsync(OrderItemDto orderItem);
    }

    public class Orders : IOrdersDal
    {
        private readonly SmartCafeContext _dbContext;
        private readonly IMapper _mapper;

        public Orders(SmartCafeContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        #region Orders

        public async Task<List<OrderDto>> GetAllOrdersAsync()
        {
            return await this._dbContext.Orders.Include("OrderItems.Product").Select(x =>
                new OrderDto
                {
                    Id = x.Id,
                    OrderDate = x.OrderDate,
                    TableId = x.TableId,
                    IsClosed = x.IsClosed,

                    OrderItems = x.OrderItems.Select(item =>
                        new OrderItemDto
                        {
                            OrderId = x.Id,
                            ProductId = item.ProductId,
                            ProductName = item.Product.Name,
                            Quantity = item.Quantity,
                            Note = item.Note
                        }
                    ).ToList()
                }
            )
            .OrderByDescending(x => x.OrderDate)
            .ToListAsync();
        }

        public async Task<List<OrderDto>> GetFilteredOrdersAsync(OrderFilterDto filter)
        {
            var orders = this._dbContext.Orders.Include("OrderItems.Product");

            if (filter.TableId.HasValue)
            {
                orders = orders.Where(x => x.TableId == filter.TableId.Value);
            }

            if (filter.OrderDate.HasValue)
            {
                orders = orders.Where(x => x.OrderDate.Date == filter.OrderDate.Value.Date);
            }

            if (filter.IsClosed.HasValue)
            {
                orders = orders.Where(x => x.IsClosed == filter.IsClosed.Value);
            }

            return await orders.Select(x =>
                new OrderDto
                {
                    Id = x.Id,
                    OrderDate = x.OrderDate,
                    TableId = x.TableId,
                    IsClosed = x.IsClosed,

                    OrderItems = x.OrderItems.Select(item =>
                        new OrderItemDto
                        {
                            OrderId = x.Id,
                            ProductId = item.ProductId,
                            ProductName = item.Product.Name,
                            Quantity = item.Quantity,
                            Note = item.Note
                        }
                    ).ToList()
                }
            )
            .OrderByDescending(x => x.OrderDate)
            .ThenBy(x => x.TableId)
            .ToListAsync();
        }

        public async Task<OrderDto> GetOrderAsync(int id)
        {
            var order = await this._dbContext.Orders.Include("OrderItems.Product").FirstOrDefaultAsync(x => x.Id == id);
            if (order != null)
            {
                return new OrderDto
                {
                    Id = order.Id,
                    OrderDate = order.OrderDate,
                    TableId = order.TableId,
                    IsClosed = order.IsClosed,

                    OrderItems = order.OrderItems.Select(item =>
                        new OrderItemDto
                        {
                            OrderId = order.Id,
                            ProductId = item.ProductId,
                            ProductName = item.Product.Name,
                            Quantity = item.Quantity,
                            Note = item.Note
                        }
                    ).ToList()
                };
            }

            return null;
        }

        public async Task<OrderDto> CreateOrderAsync(OrderDto order)
        {
            Models.Orders newOrder = this._mapper.Map<Models.Orders>(order);
            await this._dbContext.Orders.AddAsync(newOrder);
            await this._dbContext.SaveChangesAsync();

            return order;
        }

        public async Task<OrderDto> UpdateOrderAsync(OrderDto order)
        {
            var existing = await this._dbContext.Orders.FirstOrDefaultAsync(x => x.Id == order.Id);
            if (existing != null)
            {
                if (order.IsClosed.HasValue)
                {
                    existing.IsClosed = order.IsClosed.Value;
                }

                await this._dbContext.SaveChangesAsync();

                return order;
            }

            return null;
        }

        public void DeleteOrder(int id)
        {
            var existing = this._dbContext.Orders.Include(t => t.OrderItems).FirstOrDefault(x => x.Id == id);
            if (existing != null)
            {
                // delete order items
                for (int i = existing.OrderItems.Count() - 1; i >= 0; i--)
                {
                    var item = existing.OrderItems.ElementAt(i);
                    this._dbContext.OrderItems.Remove(item);
                }

                // delete order
                this._dbContext.Orders.Remove(existing);

                this._dbContext.SaveChanges();
            }
        }

        #endregion

        #region Order items

        public async Task<List<OrderItemDto>> GetOrderItemsAsync(int orderId)
        {
            var order = await this._dbContext.Orders.Include("OrderItems.Product").FirstOrDefaultAsync(x => x.Id == orderId);
            if (order != null)
            {
                return order.OrderItems.Select(x =>
                    new OrderItemDto
                    {
                        OrderId = order.Id,
                        ProductId = x.ProductId,
                        ProductName = x.Product.Name,
                        Quantity = x.Quantity,
                        Note = x.Note
                    }
                )
                .OrderBy(x => x.ProductName)
                .ToList();
            }

            return null;
        }

        public async Task<OrderItemDto> AddOrderItemAsync(OrderItemDto orderItem)
        {
            Models.OrderItems newOrderItem = this._mapper.Map<Models.OrderItems>(orderItem);
            await this._dbContext.OrderItems.AddAsync(newOrderItem);
            await this._dbContext.SaveChangesAsync();

            return orderItem;
        }

        public async Task<OrderItemDto> UpdateOrderItemAsync(OrderItemDto orderItem)
        {
            var existing = await this._dbContext.OrderItems.FirstOrDefaultAsync(x => x.OrderId == orderItem.OrderId && x.ProductId == orderItem.ProductId);
            if (existing != null)
            {
                if (orderItem.Quantity.HasValue)
                {
                    existing.Quantity = orderItem.Quantity.Value;
                }

                if (!string.IsNullOrEmpty(orderItem.Note))
                {
                    existing.Note = orderItem.Note;
                }
                else if (orderItem.Note == string.Empty)
                {
                    existing.Note = null;
                }

                await this._dbContext.SaveChangesAsync();

                return orderItem;
            }

            return null;
        }

        public async Task DeleteOrderItemAsync(OrderItemDto orderItem)
        {
            var existing = await this._dbContext.OrderItems.FirstOrDefaultAsync(x => x.OrderId == orderItem.OrderId && x.ProductId == orderItem.ProductId);
            if (existing != null)
            {
                this._dbContext.Remove(existing);
                await this._dbContext.SaveChangesAsync();
            }
        }

        #endregion
    }
}
