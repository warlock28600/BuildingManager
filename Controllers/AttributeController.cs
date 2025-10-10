using AutoMapper;
using BuldingManager.Dto.Attribute;
using BuldingManager.Services.Attribute;
using Microsoft.AspNetCore.Mvc;

namespace BuldingManager.Controllers
{
    [Controller]
    [Route("api/v1/[controller]")]
    public class AttributeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAttributeService _service;
        public AttributeController(IMapper mapper,IAttributeService service)
        {
            _mapper = mapper;
            _service= service;  
        }

        [HttpGet]
        public async Task<ActionResult<List<AttributeGetDto>>> GetAttribute()
        {
            var attributes =  await _service.GetAttributes();
            if (attributes==null)
            {
                return NotFound();  
            }
            return Ok(attributes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AttributeGetDto>> GetAttribute(int id)
        {
            var attribute = await _service.GetAttribute(id);
            if (attribute==null)
            {
                return NotFound();  
            }
            return Ok(attribute);
        }

        [HttpPost]
        public async Task<IActionResult> PostAttribute([FromBody] attributeCreateDto attribute)
        {
            await _service.CreateAttribute(attribute);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttribute(int id,[FromBody] attributeCreateDto attribute)
        {
            await _service.UpdateAttribute(id, attribute);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttribute(int id)
        {
            await _service.DeleteAttribute(id);
            return Ok();
        }


    }
}
