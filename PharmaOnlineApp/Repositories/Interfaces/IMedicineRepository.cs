using PharmaOnlineApp.Models;


namespace PharmaOnlineApp.Repositories.Interfaces
{
    public interface IMedicineRepository : IGenericRepository<Medicine>
    {
        Task<List<Medicine>> GetMedicinesWithPrescriptionAsync();

    }
}
