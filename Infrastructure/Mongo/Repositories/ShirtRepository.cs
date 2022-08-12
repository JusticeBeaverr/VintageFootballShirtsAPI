using AutoMapper;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using VintageFootballShirts.Application.Dto;
using VintageFootballShirts.Core.Repository;
using VintageFootballShirts.Infrastructure.Mongo.Document;

namespace VintageFootballShirts.Infrastructure.Mongo.Repositories
{   
    public class ShirtRepository : IShirtRepository
    {
        private readonly IMongoCollection<ShirtResponse> _shirtCollection;
        private readonly IMapper _mapper;
        public ShirtRepository(IOptions<ShirtsDatabaseSettings> shirtDatabaseSettings, IMapper mapper)
        {
            var mongoClient = new MongoClient(shirtDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(shirtDatabaseSettings.Value.DatabaseName);
            _shirtCollection = mongoDatabase.GetCollection<ShirtResponse>(shirtDatabaseSettings.Value.ShirtCollectionName);
            _mapper = mapper;
        }
        public async Task<bool> CheckShirtId(int shirtId)=>
            await _shirtCollection.Find(x => x.ShirtId == shirtId).AnyAsync();


        public async Task CreateAsync(ShirtResponseDto NewResponse) =>
            await _shirtCollection.InsertOneAsync(_mapper.Map<ShirtResponse>(NewResponse));
        

        public async Task<List<ShirtResponseDto>> GetAllAsync()
        {
            return(await GetAsync()).Select(or=>_mapper.Map<ShirtResponseDto>(or)).ToList();
        }

        public async Task<List<ShirtResponse>> GetAsync()=>
            await _shirtCollection.Find(_=>true).ToListAsync();


        public async Task UpdateAsync(int shirtId, ShirtResponseDto UpdateResponse) =>
            await _shirtCollection.ReplaceOneAsync(x => x.ShirtId == shirtId, _mapper.Map<ShirtResponse>(UpdateResponse));
        
    }
}
