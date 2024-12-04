using LibraryManagerApi.Entities;
using LibraryManagerApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using LibraryManagerApi.Enums;

namespace LibraryManagerApi.Controllers;

public class BooksController : LibraryManagerBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult Index()
    {
        // DevTips #1 - If you wanna return a 500 Error, you can use Problem, like this:
        //return Problem("Not Implemented");

        var firstBook = new Book
        {
            Id = 1,
            Title = "First Example",
            Author = "First Author",
            Gender = GenderEnum.Adventure,
            Price = 53.10,
            Quantity = 109,
        };
        var secondBook = new Book
        {
            Id = 2,
            Title = "Second Example",
            Author = "Second Author",
            Gender = GenderEnum.Fantasy,
            Price = 19.90,
            Quantity = 23,
        };

        var myBooks = new List<Book> { firstBook, secondBook };


        return Ok(myBooks);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    public IActionResult Show([FromRoute] int id)
    {
        var myBook = new Book
        {
            Id = id,
            Title = "First Example",
            Author = "First Author",
            Gender = GenderEnum.Adventure,
            Price = 53.10,
            Quantity = 109,
        };

        return Ok(myBook);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] CreateBookDTO createBookDTO)
    {
        var createdBook = new Book
        {
            Id = 1,
            Title = createBookDTO.Title,
            Author = createBookDTO.Author,
            Gender = createBookDTO.Gender,
            Price = createBookDTO.Price,
            Quantity = createBookDTO.Quantity,
        };


        return Created(String.Empty, createdBook);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Update([FromRoute] int id, [FromBody] UpdateBookDTO updateBookDTO)
    {
        var updatedBook = new Book
        {
            Id = id,
            // DevTips #2 - If you wanna to set  optional variables, you can use double interrogation to verify if it is null.
            // It is not a truthy verify. If you receive 0, you'll save 0 into your variable:
            Title = updateBookDTO.Title ?? "My Book",
            Author = updateBookDTO.Author ?? "Some Author",
            Gender = updateBookDTO.Gender ?? GenderEnum.Adventure,
            Price = updateBookDTO.Price ?? 29.90,
            Quantity = updateBookDTO.Quantity ?? 130,
        };


        return Ok(updatedBook);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }
}
