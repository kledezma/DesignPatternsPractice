using Microsoft.Identity.Client;
using Patrones.Repositorio;
using PatronesDisenoASP.Models.ViewModels;

namespace PatronesDisenoASP.Strategies
{
    public class BeerContext
    {
        private IBeerStrategy _strategy;

        public IBeerStrategy Strategy
        {
            set { _strategy = value; }
        }

        public BeerContext(IBeerStrategy beerStrategy)
        {
            _strategy = beerStrategy;
        }

        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerVM, unitOfWork); 
        }
    }
}
