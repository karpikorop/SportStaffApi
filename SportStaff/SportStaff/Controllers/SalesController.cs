using Microsoft.AspNetCore.Mvc;
using SportStaff.Models;
using SportStaff.Repositories;


namespace SportStaff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : Controller
    {

        private readonly ISaleRepository _saleRepository;
        private readonly IItemRepository _itemRepository;
        public SaleController(ISaleRepository saleRepository, IItemRepository itemRepository)
        {
            _saleRepository = saleRepository;
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public int GetAll()
        {
            var sales = _saleRepository.GetAll();

            int income = 0;
            foreach (var item in sales)
            {
                income += item.Income;
            }
            return income;
        }

        [HttpPut]
        public void Put(int id, int income)
        {
            Sale sale = new Sale();
            
            sale.Income = income;
            sale.itemId = id;
            var item = _itemRepository.Get(a => a.Id == id).ToList();
            _itemRepository.Delete(item[0]);
            _saleRepository.Update(sale);
        }

        [HttpGet("{id}")]
        public void Get(int id, int income)
        {
            Sale sale = new Sale();

            sale.Income = income;
            sale.itemId = id;
            var item = _itemRepository.Get(a => a.Id == id).ToList();
            //_itemRepository.Delete(item[0]);
            _saleRepository.Update(sale);

        }

    }
}
