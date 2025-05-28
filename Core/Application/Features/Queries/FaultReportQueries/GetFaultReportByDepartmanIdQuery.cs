using Application.Features.Results.FaultReportResults;
using MediatR;

public class GetFaultReportByDepartmanIdQuery : IRequest<List<GetFaultReportByDepartmanIdQueryResult>>
{
    public int Id { get; set; }
    public GetFaultReportByDepartmanIdQuery(int id)
    {
        Id = id;
    }
}