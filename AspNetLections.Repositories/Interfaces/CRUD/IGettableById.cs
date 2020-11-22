﻿using System.Threading.Tasks;

namespace AspNetLection.Repositories.Interfaces.CRUD
{
    public interface IGettableById<TDto, TModel>
    {
        Task<TDto> GetAsync(long id);
    }
}