using AutoMapper;
using Security.Application.Features.AppFeatures.BranchFeatures.Commands.CreateBranch;
using Security.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Persistence.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBranchRequest, Branch>().ReverseMap();
        }
    }
}
