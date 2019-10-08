using System;
using System.Collections.Generic;
using NodaTime;

namespace SmartCafe.Postgres.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int Id { get; set; }
        public int TableId { get; set; }
        public Instant OrderDate { get; set; }
        public bool IsClosed { get; set; }

        public virtual Tables Table { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
