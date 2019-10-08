using System;
using System.Collections.Generic;
using NodaTime;

namespace SmartCafe.Postgres.Models
{
    public partial class Users
    {
        public Users()
        {
            UserGroupMembers = new HashSet<UserGroupMembers>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public Instant? CreatedAt { get; set; }

        public virtual ICollection<UserGroupMembers> UserGroupMembers { get; set; }
    }
}
