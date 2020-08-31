using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Package_and_Delivery_Final_Project.Models;

namespace Package_and_Delivery_Final_Project.Models
{
    public class Package_and_Delivery_Context : DbContext
    {
        public Package_and_Delivery_Context (DbContextOptions<Package_and_Delivery_Context> options)
            : base(options)
        {
        }

        public DbSet<Package_and_Delivery_Final_Project.Models.Courier> Courier { get; set; }

        public DbSet<Package_and_Delivery_Final_Project.Models.Package> Package { get; set; }

        public DbSet<Package_and_Delivery_Final_Project.Models.Sender> Sender { get; set; }
    }
}
