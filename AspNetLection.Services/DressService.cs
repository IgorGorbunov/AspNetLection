using AspNetLection.Models.DTO;
using AspNetLection.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using AspNetLections.Repositories.Interfaces;

namespace AspNetLection.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными об одежде.
    /// </summary>
    public class DressService : IDressService
    {
        private readonly IDressRepository _repository;

        public DressService(IDressRepository repository)
        {
            _repository = repository;
        }

        public async Task<DressDto> CreateAsync(DressDto dto)
        {
            return await _repository.CreateAsync(dto);
        }

        public async Task DeleteAsync(params long[] ids)
        {
            await _repository.DeleteAsync(ids);
        }

        public async Task<DressDto> GetAsync(long id, CancellationToken token = default)
        {
            return await GetAsync(id, token);
        }

        public async Task<IEnumerable<DressDto>> GetAsync(CancellationToken token = default)
        {
            return await GetAsync(token);
        }

        public async Task<DressDto> UpdateAsync(DressDto dto)
        {
            return await UpdateAsync(dto);
        }
    }
}
