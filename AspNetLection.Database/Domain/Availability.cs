using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetLection.DAL.Domain
{
    /// <summary>
    /// Наличие в магазине.
    /// </summary>
    public class Availability
    {
        /// <summary>
        /// Идетификатор записи.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        /// <summary>
        /// Количество доступных единиц.
        /// </summary>
        [Required]
        public long Count { get; set; }

        /// <summary>
        /// Магазин.
        /// </summary>
        public Shop Shop { get; set; }

        /// <summary>
        /// Одежда.
        /// </summary>
        public Dress Dress { get; set; }
    }
}
