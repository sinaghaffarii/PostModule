using _Utilities.Application;
using _Utilities.Infrastructure;
using PostModule.Application.Contract.PostApplication;
using PostModule.Domain.PostEntity;
using PostModule.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            }).SingleOrDefault(p => p.Id == id);
        }
    }
}
