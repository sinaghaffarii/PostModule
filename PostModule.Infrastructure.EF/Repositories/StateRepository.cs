using PostModule.Domain.Services;
using PostModule.Domain.StateEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Infrastructure.EF.Repositories
{
    public class StateRepository : IStateRepository
    {
        public bool Create(State state)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Expression<Func<State, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<State> GetAll()
        {
            throw new NotImplementedException();
        }

        public State GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(State state)
        {
            throw new NotImplementedException();
        }
    }
}
