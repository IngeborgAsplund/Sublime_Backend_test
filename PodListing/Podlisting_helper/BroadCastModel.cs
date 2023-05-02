using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podlisting_helper
{
    internal class BroadCastModel
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Programimage { get; set; }
        public List<PodCastModel> Podcasts { get; set; } = new List<PodCastModel>();
    }
}
