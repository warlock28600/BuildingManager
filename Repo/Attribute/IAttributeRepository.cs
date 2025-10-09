namespace BuldingManager.Repo.Attribute
{
    public interface IAttributeRepository
    {
        public Task<List<Entities.Attribute>> GetAllAttributes();
        public Task<Entities.Attribute> GetAttributeById(int id);
        public Task CreateAttribute(Entities.Attribute attribute);
        public Task UpdateAttribute(int id, Entities.Attribute attribute);
        Task DeleteAttribute(int id);
    }
}
