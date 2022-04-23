using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PT_DataAccess;

[assembly: HostingStartup(typeof(ProbiskTwo.Areas.Identity.IdentityHostingStartup))]
namespace ProbiskTwo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection"))); // should it be default connection or applicationdbcontextconnection ? it should be defaultconnection otherwise db won't get updated and won't be seen.

                //services.AddDefaultIdentity<IdentityUser>()
                //    .AddEntityFrameworkStores<ApplicationDbContext>();
            });
        }
    }
}