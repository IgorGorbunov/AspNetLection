using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetLection.DAL.Domain
{
    /// <summary>
    /// Одежда.
    /// </summary>
    public class Dress : BaseEntity
    {
        /// <summary>
        /// Артикул.
        /// </summary>
        [StringLength(20)]
        public string ArtCode { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [StringLength(2500)]
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

        /// <summary>
        /// Поставщик.
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Идентификатор поставщика.
        /// </summary>
        public long ProviderId { get; set; }

        /// <summary>
        /// Наличие данной одежды в магазинах.
        /// </summary>
        public ICollection<Availability> Availabilities { get; set; }
    }
}
