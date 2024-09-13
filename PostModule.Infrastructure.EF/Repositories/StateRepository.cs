using PostModule.Application.Contract.StateApplication;
using PostModule.Domain.Services;
using PostModule.Domain.StateEntity;

namespace PostModule.Infrastructure.EF.Repositories
{
    public class StateRepository : Repository<int, State>, IStateRepository
    {
        private readonly Post_Context _context;
        public StateRepository(Post_Context context): base(context)
        {
            _context = context;
        }

        public List<StateViewModel> GetAllStateViewModel()
        {
          return GetAllQuery().Select(s => new StateViewModel
          {
             CreateDate = s.CreateDate.ToString(),
             Id = s.id,
             Title = s.Title,
          }).ToList();
        }

        public EditStateModel GetStateForEdit(int id)
        {
            var state = GetById(id);
            return new()
            {
                Id = state.id,
                Title = state.Title,
            };
        }
    }
}
