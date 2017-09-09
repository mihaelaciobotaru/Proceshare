using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proceshare
{
    public class Message
    {
        public int Id { get; set; }


        public int UserId { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }
    }
}
