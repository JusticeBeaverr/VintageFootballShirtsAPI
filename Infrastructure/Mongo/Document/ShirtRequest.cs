using MongoDB.Bson.Serialization.Attributes;

namespace VintageFootballShirts.Infrastructure.Mongo.Document
{
    public class ShirtRequest
    {
        /// <summary>
        /// Shirt Id
        /// </summary>
        [BsonId]
        public int ShirtId { get; set; }

        /// <summary>
        /// Shirt Club
        /// </summary>
        public string Club { get; set; }

        /// <summary>
        /// Last name of a player
        /// </summary>
        public string LastName { get; set; }

    }
}
