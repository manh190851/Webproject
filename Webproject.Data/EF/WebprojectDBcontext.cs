using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EF
{
    class WebprojectDBcontext : IdentityDbContext
    {
        public WebprojectDBcontext(DbContextOptions options) : base(options)
        {
        }
    }
}
