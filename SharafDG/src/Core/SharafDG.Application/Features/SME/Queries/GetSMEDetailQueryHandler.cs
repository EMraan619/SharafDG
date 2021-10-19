using AutoMapper;
using MediatR;
using SharafDG.Application.Contracts.Persistence;
using SharafDG.Application.Responses;
using SharafDG.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharafDG.Application.Features.SME.Queries
{
    public class GetSMEDetailQueryHandler : IRequestHandler<GetSMEDetailQuery, Response<SMEDetailVm>>
    {
        private readonly IAsyncRepository<SMEUser> _smeRepository;
        private readonly IMapper _mapper;

        public GetSMEDetailQueryHandler(IMapper mapper, IAsyncRepository<SMEUser> smeRepository)
        {
            _mapper = mapper;
            _smeRepository = smeRepository;
        }
        public async Task<Response<SMEDetailVm>> Handle(GetSMEDetailQuery request, CancellationToken cancellationToken)
        {
            int id = request.SMEId;

            var sme = await _smeRepository.GetByIdAsync(id);
            var smeDetailDto = _mapper.Map<SMEDetailVm>(sme);

            var response = new Response<SMEDetailVm>(smeDetailDto);
            return response;

        }
    }
}
