using MediatR;
using PDF_Split_Orchestrator_Infrastructure.Repositories;
using PDF_Split_Orchestrator_Shared.Interfaces;
using PDF_Split_Orchestrator_Shared.Requests.Queries;

namespace PDF_Split_Orchestrator_Application.Handlers.Commands;

public class DeleteLogsAsyncHandler<T>:IRequestHandler<T, Unit> where T : IDeleteLogsRequest
{
  private readonly ILogsRepository _repository;

  public DeleteLogsAsyncHandler(ILogsRepository repository)
  {
    _repository = repository;
  }

  public async Task<Unit> Handle(T request, CancellationToken cancellationToken)
  {
    await request.ExecuteAsync(_repository, cancellationToken);
    return Unit.Value;
  }
}