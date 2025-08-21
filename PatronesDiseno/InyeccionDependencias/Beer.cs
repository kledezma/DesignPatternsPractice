using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDiseno.InyeccionDependencias
{
    public class Beer
    {
        private string _name { get; set; }
        private string __brand { get; set; }
        public string Name
        {
            get
            {
             return _name;
            }
        }

        public Beer(string name, string brand)
        {
            _name = name;
            __brand = brand;
        }
    }
}
