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
        bool ExitTitleForCreate(string title);
        bool ExitTitleForEdit(string title, int id);
        EditCityModel GetCityForEdit(int id);
        List<CityViewModel> GetAllForState(int stateId);
    }
}
