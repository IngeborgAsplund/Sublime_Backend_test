using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podlisting_helper
{
    public class Caller
    {
       
        public async Task GetHumorPods(int channelId)
        {
            string url = "http://api.sr.se/api/v2/programs/index?channelid={channelId}/programcategoryid=133/isarchived=false/format=json";
            
            using(HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
        }
    }
}
