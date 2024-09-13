using PostModule.Application.Contract.StateApplication;
using PostModule.Domain.StateEntity;
using System.Linq.Expressions;

namespace PostModule.Domain.Services
{
    public interface IStateRepository : IRepository<int, State>
    {
        List<StateViewModel> GetAllStateViewModel();
        EditStateModel GetStateForEdit(int id);
    }
}
