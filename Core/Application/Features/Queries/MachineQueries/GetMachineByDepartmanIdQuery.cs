using Application.Features.Results.MachineResults;
using MediatR;

namespace Application.Features.Queries.MachineQueries;

public class GetMachineByDepartmanIdQuery : IRequest<List<GetMachineByDepartmanIdQueryResult>>
{
    public int Id { get; set; }

    public GetMachineByDepartmanIdQuery(int id)
    { 
       Id = id;  
    }
}