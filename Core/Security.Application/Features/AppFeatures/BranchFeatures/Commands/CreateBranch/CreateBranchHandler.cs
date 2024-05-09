using MediatR;
using Security.Application.Services.AppServices;

namespace Security.Application.Features.AppFeatures.BranchFeatures.Commands.CreateBranch
{
    public class CreateBranchHandler : IRequestHandler<CreateBranchRequest, CreateBranchResponse>
    {
        private readonly IBranchService branchService;

        public CreateBranchHandler(IBranchService branchService)
        {
            this.branchService = branchService;
        }

        public async Task<CreateBranchResponse> Handle(CreateBranchRequest request, CancellationToken cancellationToken)
        {
            await branchService.CreateBranch(request);
            return new();
        }
    }
}
