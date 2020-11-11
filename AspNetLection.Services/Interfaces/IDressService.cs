using AspNetLection.Models.DTO;
using System.Collections.Generic;

namespace AspNetLection.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с данными об одежде.
    /// </summary>
    public interface IDressService
    {
        IEnumerable<DressDto> GetAsync();
    }
}
