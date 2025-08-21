using Patrones.Repositorio;
using PatronesDisenoASP.Models.ViewModels;

namespace PatronesDisenoASP.Strategies
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork);
    }
}
