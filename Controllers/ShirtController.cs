using MediatR;
using Microsoft.AspNetCore.Mvc;
using VintageFootballShirts.Application.Dto;
using VintageFootballShirts.Application.Queries;
using VintageFootballShirts.Utils;

namespace VintageFootballShirts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShirtController : ControllerBase
    {
        private readonly ILogger _logger;
        private HttpClient _httpClient;
        private IMediator _mediator;

        public ShirtController(ILogger logger, HttpClient httpClient, IMediator mediator)
        {
            _logger = logger;
            _httpClient = httpClient;
            _mediator = mediator;
        }   
        [HttpGet("GetAllResponses")]
        public async Task<ActionResult<List<ShirtResponseDto>>> GetAllShirtResponseAsync()
        {
            try
            {
                var getShirtResponseQuery = new GetShirtResponseQuery();
                var queryResponse = await _mediator.Send(getShirtResponseQuery);
                _logger.LogInformation(LogEvents.GetAllShirtResponses, "Fetched all Shirt responses");
                return Ok(queryResponse);
            }
            catch (Exception ex)
            {
                var message = "Failed to fetch Shirt responses";
                _logger.LogWarning(LogEvents.ShirtResponseInternalError, ex, message);
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            }
        }
    }
}
