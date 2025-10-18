namespace BuldingManager.Repo.CompoundRepo
{
    public interface ICompoundRepository
    {
        public Task<IEnumerable<Entities.Compounds>> GetCompounds();
        public Task<Entities.Compounds> GetCompoundById(int id);
        public Task<Boolean> CreateCompound(Entities.Compounds compound);
        public Task<Boolean> UpdateCompound(int id,Entities.Compounds compound);
        public Task<Boolean> DeleteCompound(int id);
    }
}
