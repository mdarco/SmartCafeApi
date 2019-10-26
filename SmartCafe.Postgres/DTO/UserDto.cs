﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedAt { get; set; }
        public List<string> UserGroups { get; set; }
        public string Token { get; set; }
    }
}
