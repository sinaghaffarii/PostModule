using PostModule.Domain.CityEntity;
using PostModule.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Infrastructure.EF.Repositories
{
    internal class CityRepository : ICityRepository
    {
        public bool Create(City city)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Expression<Func<City, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAllBy(Expression<Func<City, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(City city)
        {
            throw new NotImplementedException();
        }
    }
}
