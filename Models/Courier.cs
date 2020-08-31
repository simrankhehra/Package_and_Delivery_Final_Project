using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Package_and_Delivery_Final_Project.Models
{
    public class Courier
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LogoUrl { get; set; }
        [NotMapped]
        public IFormFile Logo { get; set; }

    }
}
