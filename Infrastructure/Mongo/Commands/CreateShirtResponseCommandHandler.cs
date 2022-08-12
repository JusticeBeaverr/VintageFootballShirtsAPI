using MediatR;
using VintageFootballShirts.Application.Commands;
using VintageFootballShirts.Core.Repository;
using VintageFootballShirts.Utils;

namespace VintageFootballShirts.Infrastructure.Mongo.Commands
{
    public class CreateShirtResponseCommandHandler : IRequestHandler<CreateShirtResponseCommand>
    {
        private readonly IShirtRepository _shirtRepository;
        private readonly ILogger<CreateShirtResponseCommandHandler> _logger;

        public CreateShirtResponseCommandHandler(IShirtRepository shirtRepository, ILogger<CreateShirtResponseCommandHandler> logger)
        {
            _shirtRepository = shirtRepository;
            _logger = logger;
        }

        public async Task<Unit> Handle(CreateShirtResponseCommand response, CancellationToken cancellationToken)
        {
            try
            {
                await _shirtRepository.CreateAsync(response.ShirtResponse);
            }
            catch(Exception ex)
            {
                _logger.LogWarning(LogEvents.CreateShirtResponseCommandHandlerFailure, ex, "CreateShirtResponseCommandHandler failed!");
            }
            return Unit.Value;
        }
    }
}
