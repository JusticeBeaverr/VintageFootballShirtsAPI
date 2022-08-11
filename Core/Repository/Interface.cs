using VintageFootballShirts.Application.Dto;
using VintageFootballShirts.Infrastructure.Mongo.Document;

namespace VintageFootballShirts.Core.Repository
{
    public interface IShirtRepository
    {
        public Task CreateAsync(ShirtResponseDto NewResponse);
        public Task UpdateAsync(int shirtId, ShirtResponseDto UpdateResponse);
        public Task<List<ShirtResponse>> GetAsync();
        public Task<List<ShirtResponseDto>> GetAllAsync();
        public Task<bool> CheckShirtId(int shirtId);
    }
}
