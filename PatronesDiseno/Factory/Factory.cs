using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDiseno.Factory
{
    //Creador
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    // Concrete Creator
    public class StoreSaleFactory : SaleFactory
    {

        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }
        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }

    }

    public class InternetSaleFactory : SaleFactory {
        private decimal _discount;

        public  InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

    //Producto
    public interface ISale
    {
        public void Sell(decimal Total);
    }
    //Concrete Product
    public class StoreSale : ISale
    {
        private decimal _extra;
        public StoreSale(decimal extra)
        {
            _extra = extra;
        }
        public void Sell(decimal Total)
        {
            Console.WriteLine($"Venta en tienda {Total + _extra}");
        }
    }

    public class InternetSale : ISale
    {
        private decimal _discount;

        public InternetSale(decimal discount)
        {
            _discount = discount;
        }

        public void Sell(decimal Total)
        {
            Console.WriteLine($"Venta en Internet {Total - _discount}");

        }
    }


}
