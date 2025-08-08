using Herramientas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PatronesDisenoASP.Configuration;
using PatronesDisenoASP.Models;
using System.Diagnostics;

namespace PatronesDisenoASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> _config;
        public HomeController(IOptions<MyConfig> config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            Log.GetInstance(_config.Value.PathLog).Save("Entro a Index");
            return View();
        }

        public IActionResult Privacy()
        {
            Log.GetInstance(_config.Value.PathLog).Save("Entro a Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
