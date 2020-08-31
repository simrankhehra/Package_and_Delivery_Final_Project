using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Package_and_Delivery_Final_Project.Models;

[assembly: HostingStartup(typeof(Package_and_Delivery_Final_Project.Areas.Identity.IdentityHostingStartup))]
namespace Package_and_Delivery_Final_Project.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Package_and_Delivery_IdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Package_and_Delivery_IdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<Package_and_Delivery_IdentityContext>();
            });
        }
    }
}