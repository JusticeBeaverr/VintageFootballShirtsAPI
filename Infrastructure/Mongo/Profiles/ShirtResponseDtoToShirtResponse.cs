using AutoMapper;
using VintageFootballShirts.Application.Dto;
using VintageFootballShirts.Infrastructure.Mongo.Document;

namespace VintageFootballShirts.Infrastructure.Mongo.Profiles
{
    public class ShirtResponseDtoToShirtResponse : Profile
    {
        public ShirtResponseDtoToShirtResponse()
        {
            CreateMap<ShirtResponseDto, ShirtResponse>();
        }
    }
}
