using PharmaOnlineApp.Models;
using System.Collections.Generic;


namespace PharmaOnlineApp.Repositories.Interfaces
{
    public interface IPrescriptionRepository : IGenericRepository<Prescription>
    {
        Task<List<Prescription>> GetPrescriptionsForMedicineAsync(int medicineId);
    }
}
