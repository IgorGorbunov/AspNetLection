using System.ComponentModel.DataAnnotations;

namespace AspNetLection.Models.Requests.Dress
{
    /// <summary>
    /// Запрос на изменение позиции одежды.
    /// </summary>
    public class UpdateDressRequest : CreateDressRequest
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        [Required]
        public long Id { get; set; }
    }
}
