using AutoMapper;
using PharmaOnlineApp.Models;
using PharmaOnlineApp.Services.Interfaces;
using PharmaOnlineApp.ViewModels;

namespace PharmaOnlineApp.Mappings.Resolvers
{
    public class WithPrescriptionResolver : IValueResolver<Order, OrderIndexViewModel, bool>
    {
        private readonly IMedicineService _medicineService;

        public WithPrescriptionResolver(IMedicineService medicineService) => _medicineService = medicineService;

        public bool Resolve(Order order, OrderIndexViewModel orderIndexViewModel, bool destMember, ResolutionContext context) =>
            _medicineService.GetMedicineByIdAsync(order.MedicineId).Result.WithPrescription;
    }
}
