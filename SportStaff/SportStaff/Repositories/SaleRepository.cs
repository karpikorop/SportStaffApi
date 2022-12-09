using SportStaff.Data;
using SportStaff.Models;

namespace SportStaff.Repositories
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        public ItemRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
