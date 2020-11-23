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

        /// <summary>
        /// Инициализирует экземпляр <see cref="DressService"/>.
        /// </summary>
        /// <param name="repository">Репозиторий.</param>
        public DressService(IDressRepository repository)
        {
            _repository = repository;
        }

        ///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
        public async Task<DressDto> CreateAsync(DressDto dto)
        {
            return await _repository.CreateAsync(dto);
        }

        /// <inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
        public async Task DeleteAsync(params long[] ids)
        {
            await _repository.DeleteAsync(ids);
        }

        /// <inheritdoc cref="IGettableById{TDto}.GetAsync(long, CancellationToken)"/>
        public async Task<DressDto> GetAsync(long id, CancellationToken token = default)
        {
            return await GetAsync(id, token);
        }

        /// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<DressDto>> GetAsync(CancellationToken token = default)
        {
            return await GetAsync(token);
        }

        /// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
        public async Task<DressDto> UpdateAsync(DressDto dto)
        {
            return await UpdateAsync(dto);
        }
    }
}
