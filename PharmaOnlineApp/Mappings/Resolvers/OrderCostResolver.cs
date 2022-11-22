using AutoMapper;
using PharmaOnlineApp.Models;
using PharmaOnlineApp.Services.Interfaces;
using PharmaOnlineApp.ViewModels;

namespace PharmaOnlineApp.Mappings.Resolvers
{
        public class OrderCostResolver : IValueResolver<OrderCreateViewModel, Order, double>
        {
            private readonly IMedicineService _medicineService;

            public OrderCostResolver(IMedicineService medicineService) => _medicineService = medicineService;

            public double Resolve(OrderCreateViewModel orderCreateViewModel, Order order, double destMember, ResolutionContext context) =>
                _medicineService.GetMedicineByIdAsync(order.MedicineId).Result.Price * order.Amount;
        }
    }

