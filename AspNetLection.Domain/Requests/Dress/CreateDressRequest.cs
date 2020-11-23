using System.ComponentModel.DataAnnotations;

namespace AspNetLection.Models.Requests.Dress
{
    /// <summary>
    /// Запрос на создание позиции одежды.
    /// </summary>
    public class CreateDressRequest
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
