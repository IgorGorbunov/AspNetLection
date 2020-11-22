using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetLection.DAL.Domain;

namespace AspNetLection.DAL.Domain
{
    /// <summary>
    /// Одежда.
    /// </summary>
    public class Dress
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

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
    }
}
