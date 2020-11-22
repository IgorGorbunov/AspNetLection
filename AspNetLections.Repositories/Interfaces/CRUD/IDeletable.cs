using System.Threading.Tasks;

namespace AspNetLection.Repositories.Interfaces.CRUD
{
    public interface IDeletable
    {
        Task DeleteAsync(params long[] ids);
    }
}