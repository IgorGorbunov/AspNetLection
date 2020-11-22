using AspNetLection.Models.DTO;

namespace AspNetLection.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с данными об одежде.
    /// </summary>
    public interface IDressService : ICrudService<DressDto>
    {
    }
}
