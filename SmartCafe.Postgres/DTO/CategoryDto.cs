﻿using System;
using System.Collections.Generic;

namespace SmartCafe.Postgres.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ProductDto> Products { get; set; }
    }
}
