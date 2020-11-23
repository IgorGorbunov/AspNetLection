namespace AspNetLection.Models.Responses.Dress
{
    /// <summary>
    /// Ответ на запросы для позиций одежды.
    /// </summary>
    public class DressResponse
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
