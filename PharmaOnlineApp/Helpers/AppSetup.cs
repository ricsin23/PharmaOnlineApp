using PharmaOnlineApp.Models;
using PharmaOnlineApp.Repositories.Interfaces;
using PharmaOnlineApp.Repositories;
using PharmaOnlineApp.Services.Interfaces;
using PharmaOnlineApp.Services;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PharmaOnlineApp.Mappings;
using Microsoft.EntityFrameworkCore;

namespace PharmaOnlineApp.Helpers
{
    public static class AppSetup
    {
        public static void ConfigureAppByDefault(this IServiceCollection services, IConfiguration configuration)
        {
            AddDatabaseAndIdentity(services, configuration);
            AddDI(services);
            services.AddMvc();
        }

        private static void AddDatabaseAndIdentity(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        private static void AddDI(this IServiceCollection services)
        {
            services.AddScoped<IMedicineRepository, MedicineRepository>();
            services.AddScoped<IPrescriptionRepository, PrescriptionRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IMedicineService, MedicineService>();
            services.AddScoped<IPrescriptionService, PrescriptionService>();
            services.AddScoped<IOrderService, OrderService>(); ;
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
