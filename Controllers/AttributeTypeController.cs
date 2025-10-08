using BuldingManager.Dto.AttributeType;
using BuldingManager.Services.AttributeType;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace BuldingManager.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class AttributeTypeController : ControllerBase
    {
        private readonly IAttributeTypeService _service;

        public AttributeTypeController(IAttributeTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AttributeTypeGetDto>>> GetAttributeTypes()
        {
            var attributeTypes = await _service.GetAttributeTypes();
            return Ok(attributeTypes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AttributeTypeGetDto>> GetAttributeType(int id)
        {
            var attributeType = await _service.GetAttributeType(id);
            if (attributeType == null)
            {
                return NotFound();
            }
            return Ok(attributeType);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAttributeType([FromBody] AttributeTypeCreateAndUpdateDto attributeType)
        {
            await _service.CreateAttributeType(attributeType);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAttributeType(int id, [FromBody] AttributeTypeCreateAndUpdateDto attributeType)
        {
            await _service.UpdateAttributeType(id, attributeType);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAttributeType(int id)
        {
            await _service.DeleteAttributeType(id);
            return Ok();
        }

    }
}
