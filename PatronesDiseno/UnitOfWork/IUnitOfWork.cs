using PatronesDiseno.Models;
using PatronesDiseno.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDiseno.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepository<Beer> Beers { get; }

        public IRepository<Brand> Brands { get; }

        public void Save();
    }
}
