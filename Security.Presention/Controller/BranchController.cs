using MediatR;
using Microsoft.AspNetCore.Mvc;
using Security.Application.Features.AppFeatures.BranchFeatures.Commands.CreateBranch;
using Security.Presention.Abstraction;


namespace Security.Presention.Controller
{
    public class BranchController : ApiController
    {
        public BranchController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]

        public async Task<IActionResult> CreateBranch(CreateBranchRequest request)
        {
           CreateBranchResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
