using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Podlisting_helper;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private BroadcastProcessing processor;
        private int P1Id = 132;
        private int P2Id = 163;
        private int P3Id = 164;
        public List<BroadCastModel> P1Humor { get; set; }
        public List<BroadCastModel> P2Humor { get; set; }
        public List<BroadCastModel> P3Humor { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {         
            _logger = logger;
            
        }

        public async Task OnGet()
        {
            await LoadProgramInformation();
        }

        private async Task LoadProgramInformation() 
        {
            processor = new BroadcastProcessing();

            P1Humor = await processor.GetHumorPods(P1Id);
            P2Humor = await processor.GetHumorPods(P2Id);
            P3Humor = await processor.GetHumorPods(P3Id);
            
        }
    }
}