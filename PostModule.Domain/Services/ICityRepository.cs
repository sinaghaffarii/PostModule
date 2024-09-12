using PostModule.Domain.CityEntity;
using System.Linq.Expressions;

namespace PostModule.Domain.Services
{
    public interface ICityRepository
    {
        IEnumerable<City> GetAllBy(Expression<Func<City, bool>> expression);
        City GetById(int id);
        bool Create(City city);
        bool Update(City city);
        bool Exist(Expression<Func<City, bool>> expression);
        bool Save();
    }
}
