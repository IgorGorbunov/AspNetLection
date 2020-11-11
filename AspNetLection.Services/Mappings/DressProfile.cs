using AspNetLection.Database.Domain;
using AspNetLection.Models.DTO;
using AutoMapper;

namespace AspNetLection.Services.Mappings
{
    /// <summary>
    /// Профиль маппинга (одежда).
    /// </summary>
    public class DressProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="DressProfile"/>
        /// </summary>
        public DressProfile()
        {
            CreateMap<Dress, DressDto>();
        }
    }
}
