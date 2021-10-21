using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SharafDG.Application.Features.SME.Command.DeleteSMEUser;
using SharafDG.Application.Features.SME.Commands.UpdateSME;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharafDG.Application.Models.SME;
using SharafDG.Application.Features.SME.Commands;
using SharafDG.Application.Models.Mail;
using SharafDG.Application.Contracts.Infrastructure;

namespace SharafDG.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class SMEController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        private readonly IMailService email;


        public SMEController(IMediator mediator, ILogger<SMEController> logger, IMailService email)
        {
            _mediator = mediator;
            _logger = logger;
            this.email = email;
        }

        [HttpGet]
        public string SayHello()
        {
            return "Hello from SME";
        }

        [HttpPost("Register")]
        public async Task<ActionResult> RegisterAsSME([FromBody] CreateSMECommand register)
        {
            _logger.LogInformation("Register as SME Initiated");
            var response = await _mediator.Send(register);
            _logger.LogInformation("Register Completed");
            return Ok(response);
        }

        [HttpPut(Name = "UpdateSME")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateSMECommand updateSMECommand)
        {
            var response = await _mediator.Send(updateSMECommand);
            return Ok(response);
        }

        [HttpDelete("{id}", Name = "DeleteSMEUser")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteEventCommand = new DeleteSMEUserCommand() { SMEId = id };
            await _mediator.Send(deleteEventCommand);
            return NoContent();
        }
    }
}
