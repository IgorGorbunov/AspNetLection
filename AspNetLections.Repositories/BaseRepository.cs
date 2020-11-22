using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AspNetLection.DAL.Contexts;
using AspNetLection.DAL.Domain;
using AspNetLection.Models.DTO;
using AspNetLection.Repositories.Interfaces.CRUD;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AspNetLections.Repositories
{
    public abstract class BaseRepository<TDto, TModel> : ICrudRepository<TDto, TModel>
        where TDto : BaseDto
        where TModel : BaseEntity
    {
        private readonly IMapper _mapper;
        protected readonly AspNetLectionsContext Context;
        protected DbSet<TModel> DbSet => Context.Set<TModel>();

        protected BaseRepository(AspNetLectionsContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            await DbSet.AddAsync(entity);
            await Context.SaveChangesAsync();
            return await GetAsync(entity.Id);
        }

        public async Task DeleteAsync(params long[] ids)
        {
            var entities = await DbSet
                                .Where(x => ids.Contains(x.Id))
                                .ToListAsync();

            Context.RemoveRange(entities);
            await Context.SaveChangesAsync();
        }

        public async Task<TDto> GetAsync(long id)
        {
            var entity = await DbSet
                              .AsNoTracking()
                              .FirstOrDefaultAsync(x => x.Id == id);

            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        public async Task<TDto> UpdateAsync(TDto dto, CancellationToken token = default)
        {
            var entity = _mapper.Map<TModel>(dto);
            Context.Update(entity);
            await Context.SaveChangesAsync(token);
            var newEntity = await GetAsync(entity.Id);

            return _mapper.Map<TDto>(newEntity);
        }

        public async Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default)
        {
            var entities = await DbSet.AsNoTracking().ToListAsync();

            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);

            return dtos;
        }
    }
}