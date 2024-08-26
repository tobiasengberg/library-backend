using library_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace library_api.Controllers;


[ApiController]
public class BookController : ControllerBase
{
    private readonly LibraryDb _context;

    public BookController(LibraryDb context)
    {
        _context = context;
    }
    // GET
    [HttpGet("books")]
    public IActionResult Index()
    {
        Book[] books = _context.Books.ToArray();
        return Ok(books);
    }

    [HttpPost("books")]
    public IActionResult Post([FromBody] Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return Ok();
    }

}