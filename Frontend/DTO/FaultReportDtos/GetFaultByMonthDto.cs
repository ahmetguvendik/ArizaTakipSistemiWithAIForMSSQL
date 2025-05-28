namespace DTO.FaultReportDtos;

public class GetFaultByMonthDto
{
    public int Id { get; set; }
    public int? DepartmanId { get; set; }
    public string? DepartmanName { get; set; }
    public int Count { get; set; }
    public int Month { get; set; }
}

