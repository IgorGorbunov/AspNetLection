using AspNetLection.Models.DTO;
using AspNetLection.Models.Requests.Dress;
using AspNetLection.Models.Responses.Dress;
using AutoMapper;

namespace AspNetLection.Controllers.Mappings
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности "Одежда".
    /// </summary>
    public class DressProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="DressProfile"/>.
        /// </summary>
        public DressProfile()
        {
            CreateMap<CreateDressRequest, DressDto>();
            CreateMap<UpdateDressRequest, DressDto>();
            CreateMap<DressDto, DressResponse>();
        }
    }
}
