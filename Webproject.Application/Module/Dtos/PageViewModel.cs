using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Application.Module.Dtos
{
    public class PageViewModel<T>
    {
        public List<T> items;
        public int totalRecord;
    }
}
