using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Features.AppFeatures.BranchFeatures.Commands.CreateBranch
{
    public class CreateBranchRequest:IRequest<CreateBranchResponse>
    {
        public string BranchName { get; set; }
    }
}
