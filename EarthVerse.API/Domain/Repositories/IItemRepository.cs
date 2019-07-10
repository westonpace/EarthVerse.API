using EarthVerse.API.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarthVerse.API.Domain.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> ListAsync();
    }
}