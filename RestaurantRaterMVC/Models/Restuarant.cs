using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRaterMVC.Models
{
    public class Restuarant
    {
        public int ResteruarntID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }


    }

    public class RestuarantDbContext: DbContext
    {
        public DbSet<Restuarant>Restuarants { get; set; }


    }






}