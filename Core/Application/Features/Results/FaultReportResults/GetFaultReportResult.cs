namespace Application.Features.Results.FaultReportResults;

public class GetFaultReportResult
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ReporterName { get; set; }
    public string ReporterPhone { get; set; }
    public string ReporterEmail { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime AssignedTime { get; set; }
    public DateTime ClosedTime { get; set; }
    public string Status { get; set; }
    // Yeni, Atandı, Çözülüyor, Tamamlandı
    public int? MachineId { get; set; }
    public string? MachineName { get; set; }
    public int? AssignedToId { get; set; }
    public string? AssignedToName { get; set; }
    public int? AssignedById { get; set; }
    public string? AssignedByName { get; set; }
    public int? ClosedById { get; set; }
    public string? ClosedByName { get; set; }
    public string? ClosedDescription { get; set; }
    public int? DepartmanId { get; set; }
    public string? DepartmanName { get; set; }
}

