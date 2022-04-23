using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetailShopApp.Api.viewModels.Request;
using RetailShopApp.Api.viewModels.Response;
using RetailShopApp.Application.Queries.Bill;

namespace RetailShopApp.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public BillController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(BillDiscountResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> BillDiscount([FromQuery] BillDiscountRequest request)
        {
            var query = _mapper.Map<BillDiscountQuery>(request);
            var result = await _mediator.Send(query);
            
            return Ok(result);
        }

    }
}
