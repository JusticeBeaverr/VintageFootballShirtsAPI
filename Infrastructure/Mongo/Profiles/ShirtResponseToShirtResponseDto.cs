using AutoMapper;
using VintageFootballShirts.Application.Dto;
using VintageFootballShirts.Infrastructure.Mongo.Document;

namespace VintageFootballShirts.Infrastructure.Mongo.Profiles
{
    public class ShirtResponseToShirtResponseDto : Profile
    {
        public ShirtResponseToShirtResponseDto()
        {
            CreateMap<ShirtResponse, ShirtResponseDto>();
        }
    }
}
