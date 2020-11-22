using System.ComponentModel.DataAnnotations;

namespace AspNetLection.Models.DTO
{
    /// <summary>
    /// Базовый класс для DTO.
    /// </summary>
    public abstract class BaseDto
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        [Required]
        public long Id { get; set; }
    }
}
