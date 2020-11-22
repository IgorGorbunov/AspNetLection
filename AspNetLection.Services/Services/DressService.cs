using AspNetLection.Models.DTO;
using AspNetLection.Services.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using AspNetLection.DAL.Contexts;
using AspNetLection.DAL.Domain;


namespace AspNetLection.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными об одежде.
    /// </summary>
    public class DressService : IDressService
    {
        private readonly IMapper _mapper;
        private readonly AspNetLectionsContext _context;

        public DressService(AspNetLectionsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc cref="IDressService"/>
        public IEnumerable<DressDto> Get()
        {
            var provider = new Provider
            {
                Id = 1,
                Name = "123",
                Phone = "123"
            };

            var dress = new Dress
            {
                ArtCode = "123",
                Description = "test",
                MaxSize = 55,
                MinSize = 42,
                Provider = provider
            };

            var shop = new Shop { Phone = "1235" };

            var availability = new Availability 
            { 
                Shop = shop, 
                Dress = dress, 
                Count = 5 
            };

            _context.Providers.Add(provider);
            _context.Dresses.Add(dress);
            _context.Shops.Add(shop);
            _context.Availabilities.Add(availability);

            _context.SaveChanges();
            return _mapper.Map<IEnumerable<DressDto>>(_context.Dresses);
        }
    }
}
