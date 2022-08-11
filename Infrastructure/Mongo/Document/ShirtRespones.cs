using MongoDB.Bson.Serialization.Attributes;

namespace VintageFootballShirts.Infrastructure.Mongo.Document
{
    public class ShirtRespones
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

        /// <summary>
        /// Season when shirt from
        /// </summary>
        public string Season { get; set; }

        /// <summary>
        /// Shirt Size
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// Condition of a shirt
        /// </summary>
        public string Condition { get; set; }
    }
}
