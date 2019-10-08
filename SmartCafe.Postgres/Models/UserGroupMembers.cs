using System;
using System.Collections.Generic;

namespace SmartCafe.Postgres.Models
{
    public partial class UserGroupMembers
    {
        public int UserId { get; set; }
        public int UserGroupId { get; set; }
        public string Note { get; set; }

        public virtual Users User { get; set; }
        public virtual UserGroups UserGroup { get; set; }
    }
}
