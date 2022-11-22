using Microsoft.EntityFrameworkCore;
using PharmaOnlineApp.Models;
using PharmaOnlineApp.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaOnlineApp.Repositories
{
    public class PrescriptionRepository : GenericRepository<Prescription>, IPrescriptionRepository
    {
        public PrescriptionRepository(AppDbContext appDbContext)
            : base(appDbContext)
        { }

        public async Task<List<Prescription>> GetPrescriptionsForMedicineAsync(int medicineId) => await GetAll().Where(p => p.MedicineId == medicineId).ToListAsync();
    }
}
