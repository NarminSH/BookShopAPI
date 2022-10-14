using System;
using Application.Dtos.LanguageDtos;
using Application.Dtos.UserDtos;
using Application.Languages.Queries;
using Application.Users.Commands.CreateUser;
using Application.Users.Queries.GetUsers;
using BookShop.presentation.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ApiBaseController
    {
        [HttpGet]
        public async Task<IEnumerable<GetUserDto>> Get()
        {
            return await Mediator.Send(new GetUsersQuery());
        }

        [HttpPost]
        public async Task Post([FromBody] CreateUserCommand value)
        {
            await Mediator.Send(value);
        }
    }
}

