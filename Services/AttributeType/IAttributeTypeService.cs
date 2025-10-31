﻿using BuldingManager.Dto.AttributeType;

namespace BuldingManager.Services.AttributeType;

public interface IAttributeTypeService
{
    public Task<IEnumerable<AttributeTypeGetDto>> GetAttributeTypes();
    public Task<AttributeTypeGetDto> GetAttributeType(int attributeTypeId);
    public Task<bool> CreateAttributeType(AttributeTypeCreateAndUpdateDto attributeType);
    public Task<bool> UpdateAttributeType(int id,AttributeTypeCreateAndUpdateDto attributeType);
    public Task<bool> DeleteAttributeType(int id);
}