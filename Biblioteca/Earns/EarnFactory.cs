using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas.Earns
{
    //Creator
    public abstract class EarnFactory
    {
        public abstract IEarns GetEarns();
    }
}
