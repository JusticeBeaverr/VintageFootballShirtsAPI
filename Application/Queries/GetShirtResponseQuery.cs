using VintageFootballShirts.Application.Dto;
using MediatR;

namespace VintageFootballShirts.Application.Queries
{
    public class GetShirtResponseQuery : IRequest<List<ShirtResponseDto>>
    {
    }
}
