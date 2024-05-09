using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Security.Presention.Abstraction
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController:ControllerBase
    {
        protected readonly IMediator _mediator;

        public ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
