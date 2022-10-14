using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Dtos.CategoryDtos;
using BookShop.presentation.WebApi.Controllers;
using BookShop.src.Application.Categories.Commands.CreateCategory;
using Code.Application.Categories.Queries.GetCategories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ApiBaseController
    {
        [HttpGet]
        public async Task<IEnumerable<GetCategoryDto>> Get()
        {
            return await Mediator.Send(new GetCategoriesQuery());
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] CreateCategoryCommand command)
        {
            return await Mediator.Send(command);
        }

        //[HttpDelete]
        //public async Task Delete(DeleteCategoryCommand command)
        //{
        //    await Mediator.Send(command);
        //}

        //[HttpPut]
        //public async Task Update([FromBody] UpdateCategoryCommand command)
        //{
        //    await Mediator.Send(command);
        //}
    }
}

