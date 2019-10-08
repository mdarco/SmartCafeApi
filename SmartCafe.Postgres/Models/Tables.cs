using System;
using System.Collections.Generic;

namespace SmartCafe.Postgres.Models
{
    public partial class Tables
    {
        public Tables()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public bool IsInUse { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
