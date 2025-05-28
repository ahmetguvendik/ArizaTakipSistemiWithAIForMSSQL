namespace Domain.Entities;

public class Department : BaseEntity
{
    public string Name { get; set; }
    public ICollection<AppUser> Users { get; set; }
    public ICollection<Machine> Machines { get; set; }
}

// The Department class represents a department within the organization. It inherits from BaseEntity, which provides an Id property.