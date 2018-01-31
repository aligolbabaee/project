using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public string RegisterDate { get; set; }
        public string EditeDate { get; set; }
        public Role Role { get; set; }
        
    }
    

}