using MediatR;
using PDF_Split_Orchestrator_Infrastructure.Repositories;
using PDF_Split_Orchestrator_Shared.Entities;
using PDF_Split_Orchestrator_Shared.Interfaces;

namespace PDF_Split_Orchestrator_Application.Handlers.Queries;

public class GetLogsAsyncHandler<TRequest, TParam>:IRequestHandler<TRequest, IEnumerable<LogEntity>> where TRequest : IGetLogsRequest<TParam>
{
    private readonly ILogsRepository _repository;

    public GetLogsAsyncHandler(ILogsRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<LogEntity>> Handle(TRequest request, CancellationToken cancellationToken)
    { 
        return await request.ExecuteAsync(_repository, cancellationToken);
    }
}