using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DTO
{
    public class TableDto
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public bool? IsInUse { get; set; }
    }
}
