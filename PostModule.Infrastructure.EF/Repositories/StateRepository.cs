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
    public class StateRepository : Repository<int , State>,  IStateRepository
    {
      
    }
}
