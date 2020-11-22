using AspNetLection.DAL.Domain;
using AspNetLection.Models.DTO;
using AspNetLection.Repositories.Interfaces.CRUD;

namespace AspNetLections.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс репозитория для работы с сущностями "Одежда".
    /// </summary>
    public interface IDressRepository : ICrudRepository<DressDto, Dress>
    {
    }
}
