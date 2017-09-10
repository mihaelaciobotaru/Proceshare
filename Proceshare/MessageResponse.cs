using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proceshare
{
    public class MessageResponse
    {
        public string username { get; set; }

        public List<int> data { get; set; }

        public string requestId { get; set; }
    }
}
