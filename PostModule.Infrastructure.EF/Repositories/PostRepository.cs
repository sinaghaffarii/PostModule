using _Utilities.Application;
using _Utilities.Infrastructure;
using PostModule.Application.Contract.PostApplication;
using PostModule.Domain.PostEntity;
using PostModule.Domain.Services;


namespace PostModule.Infrastructure.EF.Repositories
{
    internal class PostRepository : Repository<int, Post>, IPostRepository
    {
        private readonly Post_Context _context;
        public PostRepository(Post_Context context) : base(context)
        {
            _context = context;
        }

        public List<PostModel> GetAllPosts()
        {
            return GetAllQuery().Select(p => new PostModel
            {
                Id = p.id,
                CityPricePlus = p.CityPricePlus,
                CreationDate = p.CreateDate.ToPersainDate(),
                InsideStatePricePlus = p.InsideStatePricePlus,
                StateCenterPricePlus = p.StateCenterPricePlus,
                StateClosePricePlus = p.StateClosePricePlus,
                StateNonClosePricePlus = p.StateNonClosePricePlus,
                Status = p.Status,
                TehranPricePlus = p.TehranPricePlus,
                Title = p.Title,
                Description = p.Description,
                Active = p.Active,
                InsideCity = p.InsideCity,
                OutSideCity = p.OutSideCity
            }).ToList();
        }

        public EditPost GetForEdit(int id)
        {
            return _context.Post.Select(p => new EditPost
            {
                Id = p.id,
                CityPricePlus = p.CityPricePlus,
                InsideStatePricePlus = p.InsideStatePricePlus,
                StateCenterPricePlus = p.StateCenterPricePlus,
                StateClosePricePlus = p.StateClosePricePlus,
                StateNonClosePricePlus = p.StateNonClosePricePlus,
                Status = p.Status,
                TehranPricePlus = p.TehranPricePlus,
                Title = p.Title,
                Description = p.Description
            }).SingleOrDefault(p => p.Id == id);
        }
    }
}
