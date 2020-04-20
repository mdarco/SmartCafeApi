using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartCafe.Postgres.DAL;
using SmartCafe.Postgres.DTO;

namespace SmartCafe.Postgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersDal _dal;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(IOrdersDal dal, ILogger<OrdersController> logger)
        {
            this._dal = dal;
            this._logger = logger;
        }

        #region Orders

        [HttpGet]
        public async Task<ActionResult<List<OrderDto>>> GetAllOrdersAsync()
        {
            var orders = await this._dal.GetAllOrdersAsync();
            return Ok(orders);
        }

        [HttpPost]
        [Route("filtered")]
        public async Task<ActionResult<List<OrderDto>>> GetFilteredOrdersAsync(OrderFilterDto filter)
        {
            var orders = await this._dal.GetFilteredOrdersAsync(filter);
            return Ok(orders);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<OrderDto>> GetOrderAsync(int id)
        {
            var order = await this._dal.GetOrderAsync(id);
            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<OrderDto>> CreateOrderAsync(OrderDto order)
        {
            var newOrder = await this._dal.CreateOrderAsync(order);
            return Ok(newOrder);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<OrderDto>> UpdateOrderAsync(OrderDto order)
        {
            var updatedOrder = await this._dal.UpdateOrderAsync(order);
            return Ok(updatedOrder);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            this._dal.DeleteOrder(id);
            return Ok();
        }

        #endregion

        #region Order items

        [HttpGet]
        [Route("{orderId}/order-items")]
        public async Task<ActionResult<List<OrderItemDto>>> GetOrderItemsAsync(int orderId)
        {
            var orderItems = await this._dal.GetOrderItemsAsync(orderId);
            return Ok(orderItems);
        }

        [HttpPost]
        [Route("{orderId}/order-items")]
        public async Task<ActionResult<OrderItemDto>> AddOrderItemAsync(OrderItemDto orderItem)
        {
            var newOrderItem = await this._dal.AddOrderItemAsync(orderItem);
            return Ok(newOrderItem);
        }

        [HttpPut]
        [Route("{orderId}/order-items")]
        public async Task<ActionResult<OrderItemDto>> UpdateOrderItemAsync(OrderItemDto orderItem)
        {
            var updatedOrderItem = await this._dal.UpdateOrderItemAsync(orderItem);
            return Ok(updatedOrderItem);
        }

        [HttpDelete]
        [Route("{orderId}/order-items")]
        public async Task<ActionResult> DeleteOrderItemAsync(OrderItemDto orderItem)
        {
            await this._dal.DeleteOrderItemAsync(orderItem);
            return Ok();
        }

        #endregion
    }
}