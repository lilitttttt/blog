﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_config.Models
{
    public class User
    {
        [Key]
        public int Id_User { get; set; }
        public string Email_User { get; set; }
        public string Login_User { get; set; }
        public string Password_User { get; set; }
        public string About_User { get; set; }
    }
}
