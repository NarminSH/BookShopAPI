using System;
using Application.Dtos.GenreDtos;
using Application.Dtos.LanguageDtos;
using Application.Genres.Commands;
using Application.Genres.Queries;
using Application.Languages.Commands;
using Application.Languages.Queries;
using BookShop.presentation.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ApiBaseController
    {
        [HttpGet]
        public async Task<IEnumerable<GetGenreDto>> Get()
        {
            return await Mediator.Send(new GetGenresQuery());
        }
        [HttpPost]
        public async Task<bool> Post([FromBody] CreateGenreCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}

