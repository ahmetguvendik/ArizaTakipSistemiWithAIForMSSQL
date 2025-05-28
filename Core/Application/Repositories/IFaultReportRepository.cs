using Application.Features.Results.FaultReportResults;
using Domain.Entities;

namespace Application.Repositories;

public interface IFaultReportRepository
{
    Task<List<FaultReport>> GetAllAsync();
    Task<FaultReport> GetFaultByIdAsync(int id);
    Task<List<FaultReport>> GetFaultByDepartmanIdAsync(int departmanId);
    Task<List<int>> GetFaultByMonthAsync();
    Task<List<GetFaultByDepartmanQueryResult>> GetFaultByDepartmanAsync();
}

