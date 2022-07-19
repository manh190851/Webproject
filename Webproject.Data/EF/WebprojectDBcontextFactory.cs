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
    public class WebprojectDBcontextFactory : IDesignTimeDbContextFactory<WebprojectDBcontext>
    {
        public WebprojectDBcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<WebprojectDBcontext>();
            optionsBuilder.UseSqlServer("Data Source=blog.db");

            return new WebprojectDBcontext(optionsBuilder.Options);
        }
    }
}
