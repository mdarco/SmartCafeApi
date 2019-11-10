using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DTO
{
    public class OrderFilterDto
    {
        public int Id { get; set; }
        public int? TableId { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool? IsClosed { get; set; }
    }
}
