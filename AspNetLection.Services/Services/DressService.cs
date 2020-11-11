using AspNetLection.Database.Mocks;
using AspNetLection.Models.DTO;
using AspNetLection.Services.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace AspNetLection.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными об одежде.
    /// </summary>
    public class DressService : IDressService
    {
        private readonly IMapper _mapper;

        public DressService(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <inheritdoc cref="IDressService"/>
        public IEnumerable<DressDto> GetAsync()
        {
            var dresses = DressMock.GetDress();
            var response = _mapper.Map<IEnumerable<DressDto>>(dresses);
            return response;
        }
    }
}
