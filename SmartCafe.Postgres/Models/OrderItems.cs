using System;
using System.Collections.Generic;

namespace SmartCafe.Postgres.Models
{
    public partial class OrderItems
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Note { get; set; }
        public int Quantity { get; set; }
        public bool IsDelivered { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
