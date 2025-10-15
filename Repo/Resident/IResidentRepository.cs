namespace BuldingManager.Repo.Resident
{
    public interface IResidentRepository
    {
        public Task<IEnumerable<Entities.ResidentEntity>> GetResidents();
        public Task<Entities.ResidentEntity?> GetResidentById(int id);
        public Task CreateResident(Entities.ResidentEntity resident);
        public Task UpdateResident(int id,Entities.ResidentEntity resident);
        public Task DeleteResident(int id);
    }
}
