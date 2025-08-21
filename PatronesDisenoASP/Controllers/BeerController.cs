using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Patrones.Modelos.Data;
using Patrones.Repositorio;
using PatronesDisenoASP.Models.ViewModels;
using PatronesDisenoASP.Strategies;

namespace PatronesDisenoASP.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> cervezas = from d in _unitOfWork.Beers.Get()
                                                  select new BeerViewModel
                                                  {
                                                      Id = d.BeerId,
                                                      Name = d.Name,
                                                      Style = d.Style,
                                                  };

            return View("Index", cervezas);
        }

        [HttpGet]
        public IActionResult Add()
        {

            GetBrandsData();
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerVM)
        {
            if(!ModelState.IsValid)
            {
                GetBrandsData();
                return View("Add",beerVM);
            }

            var context = beerVM.BrandId == null ?
                          new BeerContext(new BeerWithBrandStrategy()) :
                          new BeerContext(new BeerStrategy());

            context.Add(beerVM, _unitOfWork);

            return RedirectToAction("Index");
        }


        #region Helpers
        private void GetBrandsData()
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
        }
        #endregion
    }
}
