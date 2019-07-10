using EarthVerse.API.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarthVerse.API.Domain.Services
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> ListAsync();
    }
}