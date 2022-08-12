using VintageFootballShirts.Application.Dto;
using MediatR;

namespace VintageFootballShirts.Application.Commands
{
    public class UpdateShirtResponseCommand : IRequest
    {
        public int ShirtId { get; set; }
        public ShirtResponseDto ShirtResponse { get; set; }
    }
}
