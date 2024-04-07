﻿using CorePackages.Application.Features.Commands;
using CorePackages.Application.Features.Queries.GetAllConfigurations;
using CorePackages.Application.Features.Queries.GetByNameConfiguration;
using CorePackages.Application.Interfaces.Repository;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorePackages.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {

        private readonly IMediator mediator;
        public ConfigurationController( IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var res = new GetAllConfigurationQuery();
            return Ok(await mediator.Send(res));
        }

        [HttpPost]

        public async Task<IActionResult> Add(CreateConfiguration command)
        {
            return Ok(await mediator.Send(command));
        }



        [HttpGet("{name}")]

        public async Task<IActionResult> GetByName(string name)
        {
            var res = new GetByNameConfigurationQuery();
            res.Name = name;
            return Ok(await mediator.Send(res));
        }
    }
}
