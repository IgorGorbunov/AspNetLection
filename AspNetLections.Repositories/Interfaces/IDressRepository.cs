using AspNetLection.DAL.Domain;
using AspNetLection.Models.DTO;
using AspNetLection.Repositories.Interfaces.CRUD;

namespace AspNetLections.Repositories.Interfaces
{
    public interface IDressRepository : ICrudRepository<DressDto, Dress>
    {
    }
}
