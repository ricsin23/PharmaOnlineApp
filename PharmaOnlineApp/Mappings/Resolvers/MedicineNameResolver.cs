using AutoMapper;
using PharmaOnlineApp.Models;
using PharmaOnlineApp.Services.Interfaces;
using PharmaOnlineApp.ViewModels;

namespace PharmaOnlineApp.Mappings.Resolvers
{
    public class MedicineNameResolver : IValueResolver<Order, OrderIndexViewModel, string>
    {
        private readonly IMedicineService _medicineService;

        public MedicineNameResolver(IMedicineService medicineService) => _medicineService = medicineService;

        public string Resolve(Order order, OrderIndexViewModel orderIndexViewModel, string destMember,
            ResolutionContext context) =>
            _medicineService.GetMedicineByIdAsync(order.MedicineId).Result.Name;
    }
}
