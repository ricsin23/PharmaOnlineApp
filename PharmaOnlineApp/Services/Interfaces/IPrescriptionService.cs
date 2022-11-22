using PharmaOnlineApp.Models.DTO;
using PharmaOnlineApp.Models;

namespace PharmaOnlineApp.Services.Interfaces
{
    public interface IPrescriptionService
    {
        Task<List<Prescription>> GetAllPrescriptionsAsync();
        Task<List<PrescriptionNumber>> GetAllPrescriptionsNumbersForMedicineAsync(int medicineId);
        Task<Prescription> GetPrescriptionByIdAsync(int prescriptionId);
        Task AddPrescriptionAsync(Prescription prescription);
        Task EditPrescriptionAsync(Prescription prescription);
        Task DeletePrescriptionAsync(int prescriptionId);
    }
}
