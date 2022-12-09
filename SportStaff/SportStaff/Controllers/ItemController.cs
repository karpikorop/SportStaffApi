using Microsoft.AspNetCore.Mvc;
using SportStaff.Models;
using SportStaff.Repositories;

namespace SportStaff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : Controller
    {

        private readonly IItemRepository _itemRepository;
        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public IEnumerable<Item> GetAll()
        {
            var items = _itemRepository.GetAll();
            return items;
        }


        [HttpGet("{id}")]
        public IEnumerable<Item> Get(int id)
        {
            var items = _itemRepository.Get(a => a.Id == id);
            return items;
        }


        [HttpPost]
        public void Post(Item item)
        {
            _itemRepository.Create(item);
        }

        [HttpPut("{id}")]
        public void Put(int id, Item item)
        {
            item.Id = id;
            _itemRepository.Update(item);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var items = _itemRepository.Get(a => a.Id == id).ToList();
            _itemRepository.Delete(items[0]);
        }
    }
}