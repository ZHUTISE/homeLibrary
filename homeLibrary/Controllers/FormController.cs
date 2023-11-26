using AutoMapper;
using HomeLibrary.DTO;
using homeLibrary.Interface;
using homeLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace homeLibrary.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : Controller
    {
        private readonly IFormRepository _formRepository;
        private readonly IMapper _mapper;

        public FormController(IFormRepository formRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Author>))]

        public IActionResult GetForms()
        {
            var forms = _mapper.Map<List<FormDTO>>(_formRepository.GetForms());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(forms);
        }
    }
}