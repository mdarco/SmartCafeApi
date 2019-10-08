using System;
using System.Collections.Generic;
using NodaTime;

namespace SmartCafe.Postgres.Models
{
    public partial class UserGroups
    {
        public UserGroups()
        {
            UserGroupMembers = new HashSet<UserGroupMembers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Instant? CreatedAt { get; set; }

        public virtual ICollection<UserGroupMembers> UserGroupMembers { get; set; }
    }
}
