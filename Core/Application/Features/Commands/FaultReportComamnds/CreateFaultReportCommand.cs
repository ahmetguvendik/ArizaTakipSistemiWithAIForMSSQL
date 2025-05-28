using MediatR;

namespace Application.Features.Commands.FaultReportComamnds;

public class CreateFaultReportCommand : IRequest
{
            
    public string Title { get; set; }
    public string Description { get; set; }
    public string ReporterName { get; set; }
    public string ReporterPhone { get; set; }
    public string ReporterEmail { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Status { get; set; } = "Yeni"; // Yeni, Atandı, Çözülüyor, Tamamlandı
    public int? MachineId { get; set; }
    public int? AssignedToId { get; set; } // Teknisyen
    public int? AssignedById { get; set; } // Supervizör
}