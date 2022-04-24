using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetailShopApp.Api.viewModels.Request;
using RetailShopApp.Domain.Models;

namespace RetailShopApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthenticateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("authenticate")]
        [ProducesResponseType(typeof(AuthenticatedUser), StatusCodes.Status200OK)]
        public async Task<IActionResult> Login([FromBody] UserAuthenticateRequest)
        {
            
        }

    }
}
