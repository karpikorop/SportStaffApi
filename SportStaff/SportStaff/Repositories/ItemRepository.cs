using SportStaff.Data;
using SportStaff.Models;

namespace SportStaff.Repositories
{
    public class SaleRepository : RepositoryBase<Sale>, ISaleRepository
    {
        public SaleRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
