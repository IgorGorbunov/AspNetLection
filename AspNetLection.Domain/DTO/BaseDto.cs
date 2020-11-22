using System.ComponentModel.DataAnnotations;

namespace AspNetLection.Models.DTO
{
    public abstract class BaseDto
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        [Required]
        public long Id { get; set; }
    }
}
