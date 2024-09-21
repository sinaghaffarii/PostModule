using _Utilities.Infrastructure;
using PostModule.Application.Contract.PostPriceApplication;
using PostModule.Domain.PostEntity;
using PostModule.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Infrastructure.EF.Repositories
{
    internal class PostPriceRepository : Repository<int, PostPrice>, IPostPriceRepository
    {
        private readonly Post_Context _context;
        public PostPriceRepository(Post_Context context) : base(context)
        {
            _context = context;
        }

        public List<PostPriceModel> GetAllForPost(int postId)
        {
            return GetAllByQuery(p => p.PostId == postId).Select(p => new PostPriceModel
            {
                CityPrice = p.CityPrice,
                End = p.End,
                Id = p.id,
                InsideStatePrice = p.InsideStatePrice,
                Start = p.Start,
                StateCenterPrice = p.StateCenterPrice,
                StateClosePrice = p.StateClosePrice,
                StateNonClosePrice = p.StateNonClosePrice,
                TehranPrice = p.TehranPrice,
            }).ToList();
        }

        public EditPostPrice GetForEdit(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
           return _context.PostPrice.Select(p => new EditPostPrice
           {
               CityPrice = p.CityPrice,
               End = p.End,
               Id = p.id,
               InsideStatePrice = p.InsideStatePrice,
               Start = p.Start,
               StateCenterPrice = p.StateCenterPrice,
               StateClosePrice = p.StateClosePrice,
               StateNonClosePrice = p.StateNonClosePrice,
               TehranPrice = p.TehranPrice,  
           }).SingleOrDefault(p => p.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
