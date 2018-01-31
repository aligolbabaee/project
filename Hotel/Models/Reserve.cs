using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Reserve
    {
        public int ID { get; set; }
        public User User { get; set; }
        public string Checkin { get; set; }
        public string Checkout { get; set; }
        public Room Room { get; set; }

    }
}