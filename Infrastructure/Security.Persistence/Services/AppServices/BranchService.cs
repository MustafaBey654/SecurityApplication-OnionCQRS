using AutoMapper;
using Security.Application.Features.AppFeatures.BranchFeatures.Commands.CreateBranch;
using Security.Application.Services.AppServices;
using Security.Domain.Entities;
using Security.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Persistence.Services.AppServices
{
    public sealed class BranchService : IBranchService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;


        public BranchService(AppDbContext context, IMapper mapper = null)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateBranch(CreateBranchRequest request)
        {
            Branch branch = _mapper.Map<Branch>(request);   
            await _context.Set<Branch>().AddAsync(branch);
            await _context.SaveChangesAsync();
        }
    }
}
