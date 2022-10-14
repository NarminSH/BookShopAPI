using System;
using Application.Dtos.FormatDtos;
using Application.Dtos.GenreDtos;
using Application.Formats.Commands;
using Application.Formats.Queries;
using Application.Genres.Queries;
using Application.Languages.Commands;
using BookShop.presentation.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormatsController : ApiBaseController
    {
        [HttpGet]
        public async Task<IEnumerable<GetFormatDto>> Get()
        {
            return await Mediator.Send(new GetFormatsQuery());
        }
        [HttpPost]
        public async Task<bool> Post([FromBody] CreateFormatCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
