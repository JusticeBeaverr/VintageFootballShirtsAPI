using MediatR;
using VintageFootballShirts.Application.Dto;
using VintageFootballShirts.Application.Queries;
using VintageFootballShirts.Core.Repository;
using VintageFootballShirts.Utils;

namespace VintageFootballShirts.Infrastructure.Mongo.Queries
{
    public class GetShirtResponseQueryHandler : IRequestHandler<GetShirtResponseQuery, List<ShirtResponseDto>>
    {
        private readonly IShirtRepository _shirtRepository;
        private readonly ILogger<GetShirtResponseQueryHandler> _logger;

        public GetShirtResponseQueryHandler(IShirtRepository shirtRepository, ILogger<GetShirtResponseQueryHandler> logger)
        {
            _shirtRepository = shirtRepository;
            _logger = logger;
        }   

        public async Task<List<ShirtResponseDto>> Handle(GetShirtResponseQuery response, CancellationToken cancellationToken)
        {
            try
            {
                return await _shirtRepository.GetAllAsync();
            }
            catch(Exception ex)
            {
                _logger.LogWarning(LogEvents.GetShirtResponseQueryHandlerFailure, ex, "GetShirtResponseQueryHandler failed!");
                return null;
            }
        }
    }
}
