using AutoMapper;
using VintageFootballShirts.Application.Dto;
using VintageFootballShirts.Infrastructure.Mongo.Document;

namespace VintageFootballShirts.Infrastructure.Mongo.Profiles
{
    public class ShirtRequestDtoToShirtRequest : Profile
    {
        public ShirtRequestDtoToShirtRequest()
        {
            CreateMap<ShirtRequestDto, ShirtRequest>();
        }
    }
}
