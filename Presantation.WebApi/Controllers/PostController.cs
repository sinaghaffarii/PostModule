using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostModule.Application.Contract.PostApplication;

namespace Presantation.WebApi.Controllers
{
    [Route("api/v{version:ApiVersion}/Post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostApplication _postApplication;
        public PostController(IPostApplication postApplication)
        {
            _postApplication = postApplication;  
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _postApplication.GetAll();
            return Ok(model);
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            var model = _postApplication.GetForEdit(id);
            return Ok(model);
        } 
    }
}
