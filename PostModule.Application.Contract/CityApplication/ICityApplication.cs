using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Application.Contract.CityApplication
{
    public interface ICityApplication
    {
        bool Create(CreateCityModel command);
        bool Edit(EditCityModel command);
        bool ExitTitleForCreate(string title, int stateId);
        bool ExitTitleForEdit(string title, int id, int stateId);
        EditCityModel GetCityForEdit(int id);
        List<CityViewModel> GetAllForState(int stateId);
    }
}
