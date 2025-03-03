﻿using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Role
    {
        public int RoleID { get; set; }
        public required string RoleName { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
