using AutoMapper;
using HomeLibrary.DTO;
using homeLibrary.Interface;
using homeLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace homeLibrary.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookController : Controller
	{
		private readonly IBookRepository _bookRepository;
		private readonly IMapper _mapper;


        public BookController(IBookRepository bookRepository, IMapper mapper)
		{
			_bookRepository = bookRepository;
            _mapper = mapper;
        }

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<Book>))]

		public IActionResult GetBooks()
		{
			var books = _mapper.Map<List<BookDTO>>(_bookRepository.GetBooks());


			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(books);

        }

		[HttpGet("{bookId}")]
		[ProducesResponseType(200, Type = typeof(Book))]
		[ProducesResponseType(400)]
		public IActionResult GetBook(int bookId)
		{
			if (!_bookRepository.BookExists(bookId))
				return NotFound();

			var book = _mapper.Map<BookDTO>(_bookRepository.GetBook(bookId));

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(book);
		}
    }
}

