using System.ComponentModel.DataAnnotations;

namespace VintageFootballShirts.Application.Dto
{
    public class ShirtRequestDto
    {
        /// <summary>
        /// Shirt Id
        /// </summary>
        [Key]
        [Required]
        [Range(1, int.MaxValue)]
        public int ShirtId { get; set; }

        /// <summary>
        /// Shirt Club
        /// </summary>
        [Required, StringLength(100, MinimumLength = 1)]
        public string Club { get; set; }

        /// <summary>
        /// Last name of a player
        /// </summary>
        [StringLength(100, MinimumLength =1)]
        public string LastName { get; set; }

    }
}
