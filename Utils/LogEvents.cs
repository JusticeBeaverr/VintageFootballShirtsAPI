namespace VintageFootballShirts.Utils
{
    public class LogEvents
    {
        public const int GetAllShirtResponses = 2000;
        public const int CreateShirtResponseCreated = 2010;
        public const int UpdateShirtResponseUpdated = 2020;
        public const int ShirtResponseInternalError = 5000;
        public const int ShirtResponseBadRequest = 4000;

        public const int CreateShirtResponseCommandHandlerFailure = 4001;
        public const int UpdateShirtResponseCommandHandlerFailure = 4002;
        public const int GetShirtResponseQueryHandlerFailure = 4003;
    }
}
