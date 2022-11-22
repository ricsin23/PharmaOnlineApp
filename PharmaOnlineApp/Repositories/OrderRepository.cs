using PharmaOnlineApp.Models;
using PharmaOnlineApp.Repositories.Interfaces;

namespace PharmaOnlineApp.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext appDbContext)
            : base(appDbContext)
        { }
    }
}
