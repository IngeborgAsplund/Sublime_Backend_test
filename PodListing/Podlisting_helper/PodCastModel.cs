using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podlisting_helper
{
    internal class PodCastModel
    {
        public string Title { get; set; }
        public DateTime Publishdateutc { get; set; }
        public int Duration { get; set; }
        public string Url { get; set; }
    }
}
