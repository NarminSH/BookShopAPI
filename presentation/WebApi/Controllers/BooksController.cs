using System;
using Application.Dtos.BookDtos;
using Application.Dtos.CategoryDtos;
using BookShop.presentation.WebApi.Controllers;
using BookShop.src.Application.Books.Commands.CreateBook;
using BookShop.src.Application.Books.Queries.GetBooks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ApiBaseController
    {
        [HttpGet]
        public async Task<IEnumerable<GetBookDto>> Get()
        {
            return await Mediator.Send(new GetBooksQuery());
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] CreateBookCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}

