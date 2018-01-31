using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        public int RoomNum { get; set; }
        public int Type { get; set; }
        public string Price { get; set; }
        public DateTime  Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public string Description { get; set; }
    }
}