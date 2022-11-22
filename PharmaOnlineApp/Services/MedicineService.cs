using PharmaOnlineApp.Models.DTO;
using PharmaOnlineApp.Models;
using PharmaOnlineApp.Repositories.Interfaces;
using PharmaOnlineApp.Services.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace PharmaOnlineApp.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMapper _mapper;

        public MedicineService(IMedicineRepository medicineRepository, IMapper mapper)
        {
            _medicineRepository = medicineRepository;
            _mapper = mapper;
        }

        public async Task<List<Medicine>> GetAllMedicinesAsync() => await _medicineRepository.GetAll().ToListAsync();

        public async Task<List<MedicineName>> GetAllMedicinesNamesAsync() => _mapper.Map<List<MedicineName>>(await GetAllMedicinesAsync());

        public async Task<List<MedicineName>> GetMedicinesWithPrescriptionAsync() => _mapper.Map<List<MedicineName>>(await _medicineRepository.GetMedicinesWithPrescriptionAsync());

        public async Task<Medicine> GetMedicineByIdAsync(int medicineId) => await _medicineRepository.GetByIdAsync(medicineId);

        public async Task AddMedicineAsync(Medicine medicine) => await _medicineRepository.CreateAsync(medicine);

        public async Task DeleteMedicineAsync(int medicineId) => await _medicineRepository.DeleteAsync(medicineId);

        public async Task EditMedicineAsync(Medicine medicine) => await _medicineRepository.UpdateAsync(medicine);

    }
}