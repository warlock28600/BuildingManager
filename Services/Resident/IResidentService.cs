using BuldingManager.Dto.Residents;

namespace BuldingManager.Services.Resident
{
    public interface IResidentService
    {
        public Task<List<ResidentGetDto>> GetResidents();
        public Task<ResidentGetDto> GetResidentById(int id);
        public Task CreateResident(ResidentCreateDto residentDto);
        public Task UpdateResident(int id, ResidentCreateDto residentDto);
        public Task DeleteResident(int id);
    }
}
