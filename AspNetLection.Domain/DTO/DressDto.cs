using AspNetLection.Database.Domain;

namespace AspNetLection.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Dress"/>
    /// </summary>
    public class DressDto
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Артикул.
        /// </summary>
        public string ArtCode { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Минимальный размер.
        /// </summary>
        public int MinSize { get; set; }

        /// <summary>
        /// Максимальный размер.
        /// </summary>
        public int MaxSize { get; set; }
    }
}
