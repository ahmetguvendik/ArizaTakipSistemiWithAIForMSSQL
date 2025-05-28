namespace DTO.FaultReportDtos;

public class GetFaultReportDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ReporterName { get; set; }
    public string ReporterPhone { get; set; }
    public string ReporterEmail { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime AssignedTime { get; set; }
    public DateTime ClosedTime { get; set; }
    public string Status { get; set; } = "Yeni"; // Yeni, Atandı, Çözülüyor, Tamamlandı
    public int? MachineId { get; set; }
    public string? MachineName { get; set; }
    public int? AssignedToId { get; set; } // Teknisyen
    public string? AssignedToName { get; set; } // Teknisyen
    public int? AssignedById { get; set; } // Supervizör
    public string? AssignedByName { get; set; } // Supervizör
    public int? ClosedById { get; set; } // Kapatan
    public string? ClosedByName { get; set; } // Kapatan
    public string ClosedDescription { get; set; }
    public int? DepartmanId { get; set; }
    public string? DepartmanName { get; set; }
}