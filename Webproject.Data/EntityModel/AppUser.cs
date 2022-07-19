using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EntityModel
{
    public class AppUser : IdentityUser<Guid>
    {
        public string fullname { get; set; }
        public string gender { get; set; }
        public DateTime DOB { get; set; }
        public string phonenumber { get; set; }
        public string nation { get; set; }
        public string city { get; set; }
        public string imageUrl { get; set; }

    }
}
