using AnimalGameStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnimalGameStore.Controller
{
    [Route("https://acnhapi.com/v1/fossils/")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private IGameControllerService gameControllerService;
        private const string URL = "https://acnhapi.com/v1/fossils/";

        public GameController(IGameControllerService gameControllerService)
        {
            this.gameControllerService = gameControllerService;
        }

        // GET: api/v1/fossils/amber
        [HttpGet("{name}")]
        public ActionResult<string> GetFossilByName(string fossilName)
        {
            var fossil = gameControllerService.FindFossilByName(fossilName, URL);
            return fossil;
        }
    }
}
