using Application.Repositories;
using Application.SemanticKernel.Services;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Repositories;
using Persistance.Services;

namespace Persistance;

public static class ServiceRegistration
{
    public static void AddPersistanceService(this IServiceCollection collection)
    {
        collection.AddDbContext<FaultDbContext>(opt =>
       opt.UseSqlServer("Server=Ahmet;Database=FaultReportDb;Trusted_Connection=true;TrustServerCertificate=True"));    
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); 
        collection.AddIdentity<AppUser, AppRole>()
            .AddEntityFrameworkStores<FaultDbContext>()
            .AddDefaultTokenProviders(); // Bu satır şart!;     
        
        collection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        collection.AddScoped(typeof(IFaultReportRepository), typeof(FaultReportRepository));
        collection.AddScoped(typeof(IMachineRepository), typeof(MachineRepository));    
        collection.AddScoped(typeof(IEmailService), typeof(EmailService));
        collection.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
        collection.AddScoped<AIService>();
        
    }
}