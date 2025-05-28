using Application.Features.Results.FaultReportResults;
using MediatR;

namespace Application.Features.Queries.FaultReportQueries;

public class GetFaultReportByIdQuery : IRequest<GetFaultReportByIdQueryResult>
{
    public int Id { get; set; }

    public GetFaultReportByIdQuery(int id)
    {
        Id = id;
    }
}