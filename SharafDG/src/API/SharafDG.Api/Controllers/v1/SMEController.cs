using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharafDG.Application.Models.SME;
using SharafDG.Application.Features.SME.Commands;

namespace SharafDG.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class SMEController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public SMEController(IMediator mediator, ILogger<SMEController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpGet]
        public string SayHello()
        {
            return "Hello from SME";
        }

        [HttpPost("SME/Register")]
        public async Task<ActionResult> RegisterAsSME([FromBody] CreateSMECommand register)
        {
            _logger.LogInformation("Register as SME Initiated");
            var response = await _mediator.Send(register);
            _logger.LogInformation("Register Completed");
            return Ok(response);
        }
    }
}
