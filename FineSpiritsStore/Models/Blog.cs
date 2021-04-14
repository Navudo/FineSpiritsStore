using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineSpiritsStore.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogBody { get; set; }
        public string BlogCategory { get; set; }
    }
}
