using PostModule.Application.Contract.CityApplication;
using PostModule.Domain.CityEntity;
using System.Linq.Expressions;

namespace PostModule.Domain.Services
{
    public interface ICityRepository : IRepository<int, City>
    {
        List<CityViewModel> GetAllForState(int stateId);
        EditCityModel GetCityForEdit(int id);
    }
}
