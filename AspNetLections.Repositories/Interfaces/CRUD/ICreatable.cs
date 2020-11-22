using System.Threading.Tasks;

namespace AspNetLection.Repositories.Interfaces.CRUD
{
    public interface ICreatable<TDto, TModel>
    {
        Task<TDto> CreateAsync(TDto dto);
    }
}