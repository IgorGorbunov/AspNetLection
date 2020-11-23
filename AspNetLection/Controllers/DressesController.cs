using System.Collections.Generic;
using AspNetLection.Common.Swagger;
using AspNetLection.Models.DTO;
using AspNetLection.Services.Interfaces;
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

        /// <summary>
        /// Инициализирует экземпляр <see cref="DressesController"/>
        /// </summary>
        /// <param name="dressService">Сервис одежды.</param>
        /// <param name="logger">Логгер.</param>
        public DressesController(IDressService dressService, ILogger<DressesController> logger)
        {
            _dressService = dressService;
            _logger = logger;
        }

        /// <summary>
        /// Получение перечня доступной в магазине одежды.
        /// </summary>
        /// <returns>Коллекция сущностей "Одежда".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<DressDto>))]
        public IActionResult Get()
        {
            _logger.LogInformation("Dresses/Get was requested.");
            var response = _dressService.GetAsync();
            return Ok(response);
        }
    }
}
