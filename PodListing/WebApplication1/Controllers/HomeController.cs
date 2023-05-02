using Microsoft.AspNetCore.Mvc;
using Podlisting_helper;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private BroadcastProcessing processor;
        private int P1Id = 132;
        private int P2Id = 163;
        private int P3Id = 164;
        public List<BroadCastModel> P1Humor { get; set; }
        public List<BroadCastModel> P2Humor { get; set; }
        public List<BroadCastModel> P3Humor { get; set; }
        public async Task<IActionResult> Index()
        {
            await LoadProgramInformation();
            return View();
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
