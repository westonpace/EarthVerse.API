using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarthVerse.API.Domain.Services;
using EarthVerse.API.Domains.Models;
using Microsoft.AspNetCore.Mvc;

namespace EarthVerse.API.Controllers
{
    [Route("/api/[controller]")]
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            var item = await _itemService.ListAsync();
            return item;
        }
    }
}