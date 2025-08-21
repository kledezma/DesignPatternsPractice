using Herramientas.Earns;
using Microsoft.AspNetCore.Mvc;

namespace PatronesDisenoASP.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            //factories
         
            FoereignEarnFactory FEFactory = new FoereignEarnFactory(0.60m, 20);

            var localEarn = _localEarnFactory.GetEarns();
            var feEarn = FEFactory.GetEarns();

            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + feEarn.Earn(total);
            

            return View();
        }
    }
}
