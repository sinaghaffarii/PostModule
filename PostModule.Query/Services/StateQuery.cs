using Microsoft.EntityFrameworkCore;
using PostModule.Application.Contract.StateQuery;
using PostModule.Infrastructure.EF;


namespace PostModule.Query.Services
{
    internal class StateQuery : IStateQuery
    {
        private Post_Context _Post_Context;
        public StateQuery(Post_Context post_Context)
        {
            _Post_Context = post_Context;
        }
        public List<StateQueryModel> GetStateWithCity() =>
            _Post_Context.states.Include(s => s.Cities).Select(s => new StateQueryModel
            {
                Name = s.Title,
                Cities = s.Cities.Select(c => new CityQueryModel
                {
                    CityCode = c.id,
                    Name = c.Title,
                }).ToList()
            }).ToList();
    }
}
