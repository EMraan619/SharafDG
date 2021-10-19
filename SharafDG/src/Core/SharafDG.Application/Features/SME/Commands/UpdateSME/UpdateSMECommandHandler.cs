using AutoMapper;
using MediatR;
using SharafDG.Application.Contracts.Persistence;
using SharafDG.Application.Exceptions;
using SharafDG.Application.Responses;
using SharafDG.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharafDG.Application.Features.SME.Commands.UpdateSME
{
    public class UpdateSMECommandHandler : IRequestHandler<UpdateSMECommand, Response<int>>
    {
        private readonly IAsyncRepository<SMEUser> _smeRepository;
        private readonly IMapper _mapper;

        public UpdateSMECommandHandler(IMapper mapper, IAsyncRepository<SMEUser> smeRepository)
        {
            _mapper = mapper;
            _smeRepository = smeRepository;
        }

        public async Task<Response<int>> Handle(UpdateSMECommand request, CancellationToken cancellationToken)
        {
            var eventToUpdate = await _smeRepository.GetByIdAsync(request.SMEId);

            if (eventToUpdate == null)
            {
                throw new NotFoundException(nameof(SMEUser), request.SMEId);
            }
            _mapper.Map(request, eventToUpdate, typeof(UpdateSMECommand), typeof(SMEUser));

            await _smeRepository.UpdateAsync(eventToUpdate);

            return new Response<int>(request.SMEId, "Updated successfully ");
        }
    }
}
