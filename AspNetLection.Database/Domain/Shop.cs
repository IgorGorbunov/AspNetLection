using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetLection.DAL.Domain
{
    /// <summary>
    /// Магазины.
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        /// <summary>
        /// Телефон магазина.
        /// </summary>
        [StringLength(25)]
        [Required]
        public string Phone { get; set; }
    }
}
