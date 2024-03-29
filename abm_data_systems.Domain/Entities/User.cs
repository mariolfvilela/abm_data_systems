﻿using System;
using abm_data_systems.Domain.Entities.Common;
using abm_data_systems.Domain.Enums;

namespace abm_data_systems.Domain.Entities
{
    public class User : EntityBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles Roles { get; set; }

        /// <summary>
        /// Description of Roles
        /// </summary>
        public string RolesDescription
        {
            get
            {
                switch (Roles)
                {
                    case Roles.Admin: return "Admin";
                    case Roles.User: return "User";
                    case Roles.None: return "None";
                    default: return string.Empty;
                }
            }
        }
    }
}
