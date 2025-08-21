using Patrones.Modelos.Data;
using Patrones.Repositorio;
using PatronesDisenoASP.Models.ViewModels;

namespace PatronesDisenoASP.Strategies
{
    public class BeerWithBrandStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = beerVM.Name;
            beer.Style = beerVM.Style;

            var brand = new Brand();
            brand.BrandId = Guid.NewGuid();
            brand.Name = beerVM.OtherBrand;
            beer.BrandId = brand.BrandId;

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
