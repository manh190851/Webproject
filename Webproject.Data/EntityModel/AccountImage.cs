using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EntityModel
{
    public class AccountImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public long AccId { get; set; } 
        public GameAccount Account { get; set; }
    }
}
