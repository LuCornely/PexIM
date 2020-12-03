using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PexIM.Areas.Identity.Data;
using PexIM.Data;

[assembly: HostingStartup(typeof(PexIM.Areas.Identity.IdentityHostingStartup))]
namespace PexIM.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PexIMContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PexIMContextConnection")));

                services.AddDefaultIdentity<PexIMUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PexIMContext>();
            });
        }
    }
}