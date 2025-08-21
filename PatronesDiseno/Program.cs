// See https://aka.ms/new-console-template for more information
using PatronesDiseno.Builder;
using PatronesDiseno.Factory;
using PatronesDiseno.InyeccionDependencias;
using PatronesDiseno.Models;
using PatronesDiseno.Repository;
using PatronesDiseno.Singleton;
using PatronesDiseno.Strategy;

namespace PatronesDiseno
{
    class Program
    {
        static void Main(string[] args)
        {
            //var log = Singleton.Log.Instance;

            //log.Save("Prueba");

            //SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            //SaleFactory internetSaleFactory = new InternetSaleFactory(2);

            //ISale storeSale = storeSaleFactory.GetSale();
            //storeSale.Sell(20);

            //ISale internetSale = internetSaleFactory.GetSale();
            //internetSale.Sell(30);

            //var beer = new Beer("Pikantus", "Erdinger");
            //var drinkWithBeer =  new DrinkWithBeer(10,1,beer);


            //drinkWithBeer.Build();

            //using (var context = new TestingContext())
            //{
            //var beerRepository = new Repository<Models.Beer>(context);
            //var beer = new Models.Beer();
            //beer.Name = "Corona";
            //beer.Style = "Puulser";
            //beerRepository.Add(beer);
            //beerRepository.Save();

            //foreach (var item in beerRepository.Get())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var unitOfWork = new UnitOfWork.UnitOfWork(context);

            //var beers = unitOfWork.Beers;
            //var beer = new Models.Beer()
            //{
            //    Name = "Fuller",
            //    Style = "Porter"
            //};

            //beers.Add(beer);

            //var brands = unitOfWork.Brands;
            //var brand = new Models.Brand()
            //{
            //    Name = "CHINCHECHA"
            //};

            //brands.Add(brand);

            //unitOfWork.Save();
            //}

            // var context = new Context(new CarStrategy());
            // context.Run();
            // context.Strategy = new MotoStrategy();
            // context.Run();

            var builder = new BebidaPreparadaConcreteBuilder();
            var barmanDirector = new BarmanDirector(builder);
            barmanDirector.PrepareDrink();

            var bebida = builder.GetBebidaPreparada();

            Console.WriteLine($"Bebida preparada: {bebida.Result}");

        }
    }
}

