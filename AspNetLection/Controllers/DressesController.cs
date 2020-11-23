using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AspNetLection.Common.Swagger;
using AspNetLection.Models.DTO;
using AspNetLection.Models.Requests.Dress;
using AspNetLection.Models.Responses.Dress;
using AspNetLection.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetLection.Controllers
{
    /// <summary>
    /// Контроллер для работы с данными об одежде.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Dresses)]
    public class DressesController : ControllerBase
    {
        private readonly ILogger<DressesController> _logger;
        private readonly IDressService _dressService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Инициализирует экземпляр <see cref="DressesController"/>
        /// </summary>
        /// <param name="dressService">Сервис одежды.</param>
        /// <param name="logger">Логгер.</param>
        /// <param name="mapper">Маппер.</param>
        public DressesController(IDressService dressService, ILogger<DressesController> logger, IMapper mapper)
        {
            _dressService = dressService;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Получение перечня доступной в магазине одежды.
        /// </summary>
        /// <returns>Коллекция сущностей "Одежда".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<DressResponse>))]
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Dresses/Get was requested.");
            var response = await _dressService.GetAsync(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<DressResponse>>(response));
        }

        /// <summary>
        /// Получение одежды по Id.
        /// </summary>
        /// <returns>Cущность "Одежда".</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DressResponse))]
        public async Task<IActionResult> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Dresses/GetById was requested.");
            var response = await _dressService.GetAsync(id, cancellationToken);
            return Ok(_mapper.Map<DressResponse>(response));
        }

        /// <summary>
        /// Добавление сущности "Одежда".
        /// </summary>
        /// <returns>Cущность "Одежда".</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DressResponse))]
        public async Task<IActionResult> PostAsync(CreateDressRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Dresses/Post was requested.");
            var response = await _dressService.CreateAsync(_mapper.Map<DressDto>(request));
            return Ok(_mapper.Map<DressResponse>(response));
        }

        /// <summary>
        /// Изменение сущности "Одежда".
        /// </summary>
        /// <returns>Cущность "Одежда".</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DressResponse))]
        public async Task<IActionResult> PutAsync(UpdateDressRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Dresses/Put was requested.");
            var response = await _dressService.UpdateAsync(_mapper.Map<DressDto>(request));
            return Ok(_mapper.Map<DressResponse>(response));
        }

        /// <summary>
        /// Удаление сущностей "Одежда".
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(CancellationToken cancellationToken, params long[] ids)
        {
            _logger.LogInformation("Dresses/Delete was requested.");
            await _dressService.DeleteAsync(ids);
            return NoContent();
        }
    }
}
