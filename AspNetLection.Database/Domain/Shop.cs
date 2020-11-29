using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetLection.DAL.Domain
{
    /// <summary>
    /// Магазины.
    /// </summary>
    public class Shop : BaseEntity
    {
        /// <summary>
        /// Название магазина.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Телефон магазина.
        /// </summary>
        [StringLength(25)]
        [Required]
        public string Phone { get; set; }

        /// <summary>
        /// Наличие данной одежды в магазинах.
        /// </summary>
        public ICollection<Availability> Availabilities { get; set; }
    }
}
