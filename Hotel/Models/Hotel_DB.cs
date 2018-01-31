using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Hotel.Models
{
    public class Hotel_DB:DbContext
    {
        //bray fahmondan class db
        public Hotel_DB():base("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True")
        {

        }
        
        //table
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
    }
}