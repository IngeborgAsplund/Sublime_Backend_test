using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podlisting_helper
{
    public class Caller
    {
       
        public async Task<List<BroadCastModel>> GetHumorPods(int channelId)
        {
            APIHelper.Initialize();
            string url = "http://api.sr.se/api/v2/programs/index?channelid={channelId}/programcategoryid=133/isarchived=false/format=json";
            
            using(HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<BroadCastModel> programs = await response.Content.ReadAsAsync<List<BroadCastModel>>();
                    foreach(BroadCastModel prog in programs)
                    {
                        int id = prog.Id;
                        prog.Podcasts = await GetHumorPodEpisodes(id);
                    }
                    return programs;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
                
            }
        }
        public async Task<List<PodCastModel>> GetHumorPodEpisodes(int programid) 
        {
            string url = "http://api.sr.se/api/v2/podfiles?programid={programid}";
            using (HttpResponseMessage secondresponse = await APIHelper.APIClient.GetAsync(url))
            {
                if (secondresponse.IsSuccessStatusCode)
                {
                    List<PodCastModel> result = await secondresponse.Content.ReadAsAsync<List<PodCastModel>>();
                    if (result != null && result.Count > 0)
                    {
                        result.OrderByDescending(x => x.Publishdateutc);
                        List<PodCastModel> episodes = result.Take(3).ToList();
                        return episodes;
                    }
                    else
                    {
                        return result;
                    }

                }
                else
                {
                    throw new Exception(secondresponse.ReasonPhrase);
                }
            }
        }
    }
}
