using AspNetLection.DAL.Contexts;
using AspNetLection.DAL.Domain;
using AspNetLection.Models.DTO;
using AspNetLections.Repositories.Interfaces;
using AutoMapper;

namespace AspNetLections.Repositories
{
    public class DressRepository : BaseRepository<DressDto, Dress>, IDressRepository
    {
        public DressRepository(AspNetLectionsContext context, IMapper mapper) : base (context, mapper)
        {
        }
    }
}
