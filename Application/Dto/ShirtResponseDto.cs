using System.ComponentModel.DataAnnotations;

namespace VintageFootballShirts.Application.Dto
{
    public class ShirtResponseDto
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
        [Required, StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }
       
        /// <summary>
        /// Season when shirt from
        /// </summary>
        [Required, StringLength(100, MinimumLength = 1)]
        public string Season { get; set; }

        /// <summary>
        /// Shirt Size
        /// </summary>
        [Required, StringLength(3, MinimumLength = 1)]
        public string Size { get; set; }

        /// <summary>
        /// Condition of a shirt
        /// </summary>
        [Required, StringLength(300, MinimumLength = 1)]
        public string Condition { get; set; }

    }
}
