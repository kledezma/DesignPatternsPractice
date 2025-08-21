using PatronesDiseno.Models;
using PatronesDiseno.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDiseno.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private TestingContext testingContext;
        private IRepository<Beer> _beers;
        private IRepository<Brand> _brands;

        public IRepository<Beer> Beers
        {
            get
            {
                return _beers == null ? _beers = new Repository<Beer>(testingContext) : _beers;
            }
        }

        public IRepository<Brand> Brands
        {
            get
            {
                return _brands == null ? _brands = new Repository<Brand>(testingContext) : _brands;
            }
        }

        public UnitOfWork(TestingContext testingContext)
        {
            this.testingContext = testingContext;
        }

        public void Save()
        {
            testingContext.SaveChanges();
        }
    }
}
