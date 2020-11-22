using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetLection.DAL.Domain
{
    public class Provider : BaseEntity
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Телефон.
        /// </summary>
        [StringLength(25)]
        [Required]
        public string Phone { get; set; }
    }
}
