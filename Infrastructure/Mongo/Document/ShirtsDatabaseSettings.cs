namespace VintageFootballShirts.Infrastructure.Mongo.Document
{
    public class ShirtsDatabaseSettings
    {
            public string ConnectionString { get; set; } = null!;

            public string DatabaseName { get; set; } = null!;

            public string ShirtCollectionName { get; set; } = null!;
    }
}
