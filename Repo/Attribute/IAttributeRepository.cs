namespace BuldingManager.Repo.Attribute
{
    public interface IAttributeRepository
    {
        public Task<List<Entities.Attribute>> GetAllAttributes();
        public Task<Entities.Attribute> GetAttributeById(int id);
        public Task<bool> CreateAttribute(Entities.Attribute attribute);
        public Task<bool> UpdateAttribute(int id, Entities.Attribute attribute);
        public Task<bool> DeleteAttribute(int id);
    }
}
