using VastWalks.API.Models.Domain;

namespace VastWalks.API.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
