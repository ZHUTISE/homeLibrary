using AutoMapper;
using HomeLibrary.DTO;
using homeLibrary.Interface;
using homeLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace homeLibrary.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : Controller
    {
        private readonly IStatusRepository _statusRepository;
        private readonly IMapper _mapper;

        public StatusController(IStatusRepository statusRepository, IMapper mapper)
        {
            _statusRepository = statusRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Author>))]

        public IActionResult GetForms()
        {
            var statuses = _mapper.Map<List<StatusDTO>>(_statusRepository.GetStatuses());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(statuses);
        }
    }
}