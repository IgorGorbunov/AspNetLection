using AspNetLection.DAL.Contexts;
using AspNetLection.DAL.Domain;
using AspNetLection.Models.DTO;
using AspNetLections.Repositories.Interfaces;
using AutoMapper;

namespace AspNetLection.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями "Одежда".
    /// </summary>
    public class DressRepository : BaseRepository<DressDto, Dress>, IDressRepository
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="DressRepository"/>.
        /// </summary>
        /// <param name="context">Контекст данных.</param>
        /// <param name="mapper">Маппер.</param>
        public DressRepository(AspNetLectionsContext context, IMapper mapper) : base (context, mapper)
        {
        }
    }
}
