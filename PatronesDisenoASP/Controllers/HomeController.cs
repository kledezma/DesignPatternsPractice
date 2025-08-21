using Herramientas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Patrones.Modelos.Data;
using PatronesDiseno.Repositorio;
using PatronesDisenoASP.Configuration;
using PatronesDisenoASP.Models;
using System.Diagnostics;

namespace PatronesDisenoASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> _config;
        private readonly IRepository<Beer> _beerRepository;
        public HomeController(IOptions<MyConfig> config, IRepository<Beer> repository)
        {
            _config = config;
            _beerRepository = repository;
        }

        public IActionResult Index()
        {
            Log.GetInstance(_config.Value.PathLog).Save("Entro a Index");

            IEnumerable<Beer> lst = _beerRepository.Get();


            return View("Index", lst);
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
