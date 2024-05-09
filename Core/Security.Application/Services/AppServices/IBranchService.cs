using Security.Application.Features.AppFeatures.BranchFeatures.Commands.CreateBranch;

namespace Security.Application.Services.AppServices
{
    public interface IBranchService
    {
        Task CreateBranch(CreateBranchRequest request);
    }
}
