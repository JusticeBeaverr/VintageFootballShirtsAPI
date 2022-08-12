using MediatR;
using VintageFootballShirts.Application.Commands;
using VintageFootballShirts.Core.Repository;
using VintageFootballShirts.Utils;

namespace VintageFootballShirts.Infrastructure.Mongo.Commands
{
    public class UpdateShirtResponseCommandHandler
    {
        private readonly IShirtRepository _shirtRepository;
        private readonly ILogger<UpdateShirtResponseCommandHandler> _logger;

        public UpdateShirtResponseCommandHandler(IShirtRepository shirtRepository, ILogger<UpdateShirtResponseCommandHandler> logger)
        {
            _shirtRepository = shirtRepository;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateShirtResponseCommand response, CancellationToken cancellationToken)
        {
            try
            {
                await _shirtRepository.UpdateAsync(response.ShirtId, response.ShirtResponse);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.UpdateShirtResponseCommandHandlerFailure, ex, "UpdateShirtResponseCommandHandler failed!");
            }
            return Unit.Value;
        }
    }
}
