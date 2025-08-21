using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas.Earns
{

    //Concrete Creator
    public class FoereignEarnFactory : EarnFactory
    {
        private decimal _percentage;
        private decimal _extra; 
        public FoereignEarnFactory(decimal percentage, decimal extra)
        {
            _percentage = percentage;
            _extra = extra;
        }

        public override IEarns GetEarns()
        {
            return new FoereignEarn(_percentage,_extra);
        }
    }

}
