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

namespace SharafDG.Application.Features.SME.Commands.CreateSME
{
   public class CreateSMECommandHandler : IRequestHandler<CreateSMECommand, Response<CreateSMEDto>>
    {
        private readonly IAsyncRepository<SMEUser> _smeRepository;
        private readonly IMapper _mapper;

        public CreateSMECommandHandler(IMapper mapper, IAsyncRepository<SMEUser> smeRepository)
        {
            _mapper = mapper;
            _smeRepository = smeRepository;
        }

        public async Task<Response<CreateSMEDto>> Handle(CreateSMECommand request, CancellationToken cancellationToken)
        {
            var createSMECommandResponse = new Response<CreateSMEDto>();

            var validator = new CreateSMECommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createSMECommandResponse.Succeeded = false;
                createSMECommandResponse.Errors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    //CreateSMECommandResponse.Errors.Add(error.ErrorMessage);
                }
            }
            else
            {
                var sme = new SMEUser()
                {
                    Name = request.Name,
                    Email = request.Email,
                    Password = request.Password,
                    PhoneNumber = request.PhoneNumber,
                    CompanyName = request.CompanyName,
                    CompanyAddress = request.CompanyAddress,
                    CompanyPhone = request.CompanyPhone,
                    CompanyWebsite = request.CompanyWebsite,
                    AlternateNumber = request.AlternateNumber,
                    TypeOfBusiness = request.TypeOfBusiness
                };

                sme = await _smeRepository.AddAsync(sme);
                createSMECommandResponse.Data = _mapper.Map<CreateSMEDto>(sme);
                createSMECommandResponse.Succeeded = true;
                createSMECommandResponse.Message = "success";

            }
            return createSMECommandResponse;
        }
    }
}
