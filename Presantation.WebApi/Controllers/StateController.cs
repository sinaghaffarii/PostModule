using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostModule.Application.Contract.StateQuery;

namespace Presantation.WebApi.Controllers
{
    [Route("api/v{version:ApiVersion}/State")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateQuery _stateQuery;
        public StateController(IStateQuery stateQuery)
        {
            _stateQuery = stateQuery;
        }
        /// <summary>
        /// دریافت لیست استان ها به همراه شهر های آن و کد شهر 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _stateQuery.GetStateWithCity();
            return Ok(model);
        }
    }
}
