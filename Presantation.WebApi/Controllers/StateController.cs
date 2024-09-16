using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presantation.WebApi.Controllers
{
    [Route("api/v{version:ApiVersion}/State")]
    [ApiController]
    public class StateController : ControllerBase
    {
    }
}
