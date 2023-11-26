using AutoMapper;
using HomeLibrary.DTO;
using homeLibrary.Interface;
using homeLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace homeLibrary.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : Controller
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Author>))]

        public IActionResult GetAuthors()
        {
            var authors = _mapper.Map<List<AuthorDTO>>(_authorRepository.GetAuthors());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(authors);
        }
    }
}