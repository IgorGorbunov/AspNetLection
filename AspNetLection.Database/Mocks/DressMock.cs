using AspNetLection.Database.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetLection.Database.Mocks
{
    /// <summary>
    /// Mock для коллекции сущностей "Одежда".
    /// </summary>
    public static class DressMock
    {
        /// <summary>
        /// Получение коллекции сущности "Одежда".
        /// </summary>
        /// <returns>Коллекция сущностей "Одежда".</returns>
        public static IEnumerable<Dress> GetDress()
        {
            return new List<Dress> {
                new Dress {Id = 1, ArtCode = "123", Description = "Платье", MaxSize = 54, MinSize = 42},
                new Dress {Id = 2, ArtCode = "1234", Description = "Пальто женское", MaxSize = 56, MinSize = 42},
                new Dress {Id = 1, ArtCode = "1235", Description = "Пальто мужское", MaxSize = 58, MinSize = 42},
            };
        }
    }
}
