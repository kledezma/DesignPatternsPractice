using Patrones.Modelos.Data;
using Patrones.Repositorio;
using PatronesDisenoASP.Models.ViewModels;

namespace PatronesDisenoASP.Strategies
{
    public class BeerStrategy : IBeerStrategy
    {

        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = beerVM.Name;
            beer.Style = beerVM.Style;
            beer.BrandId = (Guid)beerVM.BrandId;

            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
