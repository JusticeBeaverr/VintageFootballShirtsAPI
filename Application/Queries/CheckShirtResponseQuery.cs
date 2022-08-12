using MediatR;

namespace VintageFootballShirts.Application.Queries
{
    public class CheckShirtResponseQuery : IRequest<bool>
    {
        public int ShirtId { get; set; }
    }
}
