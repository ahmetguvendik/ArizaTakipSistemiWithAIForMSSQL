using MediatR;

namespace Application.Features.Commands.FaultReportComamnds;

public class CloseFaultCommand : IRequest   
{
    public int Id { get; set; }
    public int MachineId { get; set; } 
    public string FaultDescription { get; set; }
    public int ClosedById { get; set; }
    public string Status { get; set; }  
    public DateTime ClosedTime { get; set; }        
}
