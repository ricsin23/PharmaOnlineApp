using PharmaOnlineApp.Models;
using PharmaOnlineApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace PharmaOnlineApp.Repositories
{
    public class MedicineRepository : GenericRepository<Medicine>, IMedicineRepository
    {
        public MedicineRepository(AppDbContext appDbContext)
            : base(appDbContext)
        { }

        public async Task<List<Medicine>> GetMedicinesWithPrescriptionAsync() => await GetAll().Where(m => m.WithPrescription == true).ToListAsync();
    }
}
