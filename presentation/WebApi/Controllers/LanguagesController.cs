using System;
using Application.Dtos.CategoryDtos;
using Application.Dtos.LanguageDtos;
using Application.Languages.Commands;
using Application.Languages.Queries;
using BookShop.presentation.WebApi.Controllers;
using Code.Application.Categories.Queries.GetCategories;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ApiBaseController
    {
        [HttpGet]
        public async Task<IEnumerable<GetLanguageDto>> Get()
        {
            return await Mediator.Send(new GetLanguagesQuery());
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] CreateLanguageCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}

