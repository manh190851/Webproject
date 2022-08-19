using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EF
{
    public class WebprojectDbContextFactory : IDesignTimeDbContextFactory<WebprojectDbContext>
    {
        public WebprojectDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionstring = configuration.GetConnectionString("WebprojecDbContext");

            var optionsBuilder = new DbContextOptionsBuilder<WebprojectDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);

            return new WebprojectDbContext(optionsBuilder.Options);
        }
    }
}
