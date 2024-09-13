using VastWalks.API.Models.Domain;

namespace VastWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsync();
        Task<Region?> GetByIdAsync(Guid id);

        Task<Region> CreateAsync(Region region);

        Task<Region?> DeleteAsync(Guid id);

        Task<Region?> UpdateAsync(Guid id, Region region);
    }
}
