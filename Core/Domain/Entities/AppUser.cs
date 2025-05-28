using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class AppUser : IdentityUser<int>
{
    public AppUser() { }
    public string NameSurname { get; set; }
    public int? DepartmentId { get; set; }
    public Department Department { get; set; }
    public ICollection<FaultReport> AssignedFaultReports { get; set; }
    public ICollection<FaultReport> AssignedByReports { get; set; }
    public ICollection<FaultReport> ClosedByReports { get; set; }
}

