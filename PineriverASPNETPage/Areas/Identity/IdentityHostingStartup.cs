using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PineriverASPNETPage.Areas.Identity.Data;
using PineriverASPNETPage.Models;

[assembly: HostingStartup(typeof(PineriverASPNETPage.Areas.Identity.IdentityHostingStartup))]
namespace PineriverASPNETPage.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AccountContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AccountContextConnection")));

                services.AddDefaultIdentity<AccountUser>()
                    .AddEntityFrameworkStores<AccountContext>();
            });
        }
    }
}