using AutoMapper;
using VintageFootballShirts.Application.Dto;
using VintageFootballShirts.Infrastructure.Mongo.Document;

namespace VintageFootballShirts.Infrastructure.Mongo.Profiles
{
    public class ShirtRequestToShirtRequestDto : Profile
    {
        public ShirtRequestToShirtRequestDto()
        {
            CreateMap<ShirtRequest, ShirtRequestDto>();
        }
    }
}
