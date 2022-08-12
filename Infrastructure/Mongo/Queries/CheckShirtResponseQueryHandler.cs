using MediatR;
using VintageFootballShirts.Application.Queries;
using VintageFootballShirts.Core.Repository;

namespace VintageFootballShirts.Infrastructure.Mongo.Queries
{
    public class CheckShirtResponseQueryHandler : IRequestHandler<CheckShirtResponseQuery, bool>
    {
        private readonly IShirtRepository _shirtRepository;

        public CheckShirtResponseQueryHandler(IShirtRepository shirtRepository)
        {
            _shirtRepository = shirtRepository;
        }

        public async Task<bool> Handle(CheckShirtResponseQuery request, CancellationToken cancellationToken)
        {
            return await _shirtRepository.CheckShirtId(request.ShirtId);
        }
    }
}
