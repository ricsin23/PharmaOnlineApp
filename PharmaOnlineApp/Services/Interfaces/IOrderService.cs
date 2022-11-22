using PharmaOnlineApp.Models;
using PharmaOnlineApp.ViewModels;

namespace PharmaOnlineApp.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderIndexViewModel>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(int orderId);
        Task AddOrderAsync(OrderCreateViewModel orderCreateViewModel);
        Task EditOrderAsync(Order order);
        Task DeleteOrderAsync(int orderId);
    }
}
