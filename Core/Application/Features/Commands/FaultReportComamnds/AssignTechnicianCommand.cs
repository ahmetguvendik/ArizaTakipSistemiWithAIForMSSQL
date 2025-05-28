using System.Security.Principal;
using MediatR;

namespace Application.Features.Commands.FaultReportComamnds;

public class AssignTechnicianCommand : IRequest
{
    public int Id { get; set; }
    public int AssignnedToId { get; set; }
    public int AssignnedById { get; set; }
    public string Statues { get; set; } 
    public DateTime AssignedTime { get; set; } 
}