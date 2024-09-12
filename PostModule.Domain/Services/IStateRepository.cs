using PostModule.Domain.StateEntity;
using System.Linq.Expressions;

namespace PostModule.Domain.Services
{
    public interface IStateRepository
    {
        IEnumerable<State> GetAll();
        State GetById(int id);
        bool Create(State state);
        bool Update(State state);
        bool Exist(Expression<Func<State, bool>> expression);
        bool Save();
    }
}
