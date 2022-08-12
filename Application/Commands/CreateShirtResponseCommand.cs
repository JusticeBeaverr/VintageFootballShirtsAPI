using VintageFootballShirts.Application.Dto;
using MediatR;

namespace VintageFootballShirts.Application.Commands
{
    public class CreateShirtResponseCommand : IRequest
    {
        public ShirtResponseDto ShirtResponse { get; set; }
    }
}
