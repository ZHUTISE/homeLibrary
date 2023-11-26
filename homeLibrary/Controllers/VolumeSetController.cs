using AutoMapper;
using HomeLibrary.DTO;
using homeLibrary.Interface;
using homeLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace homeLibrary.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class VolumeSetController : Controller
    {
        private readonly IVolumeSetRepository _volumeSetRepository;
        private readonly IMapper _mapper;

        public VolumeSetController(IVolumeSetRepository volumeSetRepository, IMapper mapper)
        {
            _volumeSetRepository = volumeSetRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Author>))]

        public IActionResult GetVolumeSets()
        {
            var volumeSets = _mapper.Map<List<VolumeSetDTO>>(_volumeSetRepository.GetVolumeSets());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(volumeSets);
        }
    }
}