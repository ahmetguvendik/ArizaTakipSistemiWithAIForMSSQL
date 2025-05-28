namespace DTO.FaultReportDtos;

public class TeknisyenAtamaDto
{
    public int id { get; set; }
    public int AssignnedToId { get; set; }
    public int AssignnedById { get; set; }   
    public string Statues { get; set; }
    public DateTime AssignedTime { get; set; }  
}