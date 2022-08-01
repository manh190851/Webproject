using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EntityModel
{
    public class Category
    {
        public int CateId { get; set; }
        public string CateName { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Game> Games {get; set; } 
    }
}
