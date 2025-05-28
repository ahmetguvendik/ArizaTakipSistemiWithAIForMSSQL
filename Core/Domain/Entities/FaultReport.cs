namespace Domain.Entities;

public class FaultReport : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ReporterName { get; set; }
    public string ReporterPhone { get; set; }
    public string ReporterEmail { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime AssignedTime { get; set; }
    public DateTime ClosedTime { get; set; }
    public string Status { get; set; }
    public int? MachineId { get; set; }
    public Machine Machine { get; set; }
    public int? AssignedToId { get; set; }
    public AppUser AssignedTo { get; set; }
    public int? AssignedById { get; set; }
    public AppUser AssignedBy { get; set; }
    public int? ClosedById { get; set; }
    public AppUser ClosedBy { get; set; }
    public string? ClosedDescription { get; set; }
}




