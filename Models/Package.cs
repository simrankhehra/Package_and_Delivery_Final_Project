using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Package_and_Delivery_Final_Project.Models
{
    public class Package
    {
        public int Id { get; set; }

        public int CourierId { get; set; }

        public int SenderId { get; set; }

        public Courier Courier { get; set; }

        public Sender Sender { get; set; }

        public string Description { get; set; }

        public string DeliveryAddress { get; set; }

        public DateTime Submitted { get; set; }

        public PackageStatus PackageStatus { get; set; }
        


    }


    public enum PackageStatus { 
       
        INFLIGHT, PENDING, DELIVERED
    
    }
}
