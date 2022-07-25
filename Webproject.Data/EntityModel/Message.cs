using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EntityModel
{
    public class Message
    {
        public long MessageId { get; set; }
        public Guid SenderId { get; set; }
        public AppUser Sender { get; set; }
        public Guid ReceiverId { get;set; }
        public AppUser Receiver { get; set; }
        public string? Content { get; set; }
        public DateTime Created { get; set; }
    }
}
