using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using poc_aspnetcore_mvc.Models;
using System.Diagnostics;

namespace poc_aspnetcore_mvc.Controllers
{
    [Route("")]
    [Route("gestao")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        public IActionResult Index(string id, string categoria)
        {
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("error")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
