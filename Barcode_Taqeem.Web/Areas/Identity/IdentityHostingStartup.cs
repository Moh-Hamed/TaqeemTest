using System;
using Barcode_Taqeem.Web.Areas.Identity.Data;
using Barcode_Taqeem.Web.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Barcode_Taqeem.Web.Areas.Identity.IdentityHostingStartup))]
namespace Barcode_Taqeem.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Barcode_TaqeemIdentityDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Barcode_TaqeemIdentityDBContextConnection")));

                services.AddDefaultIdentity<IdentityUser_Employee>(options =>
                options.SignIn.RequireConfirmedAccount = true
                
                
                )
                    .AddEntityFrameworkStores<Barcode_TaqeemIdentityDBContext>();
            });
        }
    }
}