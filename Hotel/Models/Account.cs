﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
    public class Register
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }

}