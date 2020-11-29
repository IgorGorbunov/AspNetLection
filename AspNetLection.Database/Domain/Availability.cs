namespace AspNetLection.DAL.Domain
{
    /// <summary>
    /// Наличие в магазине.
    /// </summary>
    public class Availability : BaseEntityWithLinks<Dress, Shop>
    {
        /// <summary>
        /// Количество доступных единиц.
        /// </summary>
        public long Count { get; set; }
    }
}
