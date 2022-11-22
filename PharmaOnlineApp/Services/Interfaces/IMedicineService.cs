using PharmaOnlineApp.Models.DTO;
using PharmaOnlineApp.Models;

namespace PharmaOnlineApp.Services.Interfaces
{
    public interface IMedicineService
    {
        Task<List<Medicine>> GetAllMedicinesAsync();
        Task<List<MedicineName>> GetAllMedicinesNamesAsync();
        Task<List<MedicineName>> GetMedicinesWithPrescriptionAsync();
        Task<Medicine> GetMedicineByIdAsync(int medicineId);
        Task AddMedicineAsync(Medicine medicine);
        Task EditMedicineAsync(Medicine medicine);
        Task DeleteMedicineAsync(int medicineId);
    }
}