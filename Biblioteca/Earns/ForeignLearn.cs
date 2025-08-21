using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas.Earns
{
    public class FoereignEarn : IEarns
    {

        private decimal _percentage;
        private decimal _extra;
        public FoereignEarn(decimal percentage, decimal extra)
        {
            _percentage = percentage;
            _extra = extra;
        }

        public decimal Earn(decimal amount)
        {
            return (amount * _percentage) + _extra;
        }
    }
}
