using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Hotel.Models
{
    public class Hotel_DB:DbContext
    {
        public Hotel_DB()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}