using MediatR;
using Microsoft.AspNetCore.DataProtection;
using SharafDG.Application.Contracts.Persistence;
using SharafDG.Application.Exceptions;
using SharafDG.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharafDG.Application.Features.SME.Command.DeleteSMEUser
{
    public class DeleteSMEUserCommandHandler : IRequestHandler<DeleteSMEUserCommand>
    {
        private readonly IAsyncRepository<SMEUser> _asyncRepository;
        private readonly IDataProtector _protector;

        public DeleteSMEUserCommandHandler(IAsyncRepository<SMEUser> asyncRepository, IDataProtectionProvider provider)
        {
            _asyncRepository = asyncRepository;
            _protector = provider.CreateProtector("");
        }

        public async Task<Unit> Handle(DeleteSMEUserCommand request, CancellationToken cancellationToken)
        {
            int smeId = request.SMEId;
            var eventToDelete = await _asyncRepository.GetByIdAsync(smeId);

            if (eventToDelete == null)
            {
                throw new NotFoundException(nameof(SMEUser), smeId);
            }

            await _asyncRepository.DeleteAsync(eventToDelete);
            return Unit.Value;
        }
    }
}
