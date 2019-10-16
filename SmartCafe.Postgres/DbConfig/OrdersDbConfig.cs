using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartCafe.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DbConfig
{
    public class OrdersDbConfig : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            DateTime startDate = new DateTime(2019, 1, 1);
            DateTime endDate = new DateTime(2019, 10, 1);

            int orderId = 1;

            var orders = new Faker<Orders>()
                .RuleFor(o => o.Id, r => orderId++)
                .RuleFor(o => o.TableId, r => r.Random.Number(1, 3))
                .RuleFor(o => o.OrderDate, r => r.Date.Between(startDate, endDate))
                .RuleFor(o => o.IsClosed, r => true);

            var ordersArray = orders.Generate(50);

            builder.HasData(ordersArray);
        }
    }
}
