using EarthVerse.API.Domain.Repositories;
using EarthVerse.API.Domains.Models;
using EarthVerse.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarthVerse.API.Persistence.Repositories
{
    public class ItemRepository : BaseRepository, IItemRepository
    {
        public ItemRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Item>> ListAsync()
        {
            return await _context.Item.ToListAsync();
        }
    }
}
