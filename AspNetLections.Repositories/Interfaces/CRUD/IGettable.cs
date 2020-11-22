using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetLection.Repositories.Interfaces.CRUD
{
    public interface IGettable<TDto, TModel>
    {
        Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default);
    }
}