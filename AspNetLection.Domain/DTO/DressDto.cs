using AspNetLection.DAL.Domain;
using System.ComponentModel.DataAnnotations;

namespace AspNetLection.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Dress"/>
    /// </summary>
    public class DressDto
    {
        /// <summary>
        /// Артикул.
        /// </summary>
        [Required]
        public string ArtCode { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [MaxLength(2000)]
        public string Description { get; set; }

        /// <summary>
        /// Минимальный размер.
        /// </summary>
        [Required]
        public int MinSize { get; set; }

        /// <summary>
        /// Максимальный размер.
        /// </summary>
        [Required]
        public int MaxSize { get; set; }
    }
}
