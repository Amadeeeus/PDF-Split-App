using MediatR;
using PDF_Split_Orchestrator_Infrastructure.Repositories;

namespace PDF_Split_Orchestrator_Shared.Interfaces;

public interface IDeleteLogsRequest:IRequest<Unit>
{
    Task ExecuteAsync(ILogsRepository repository, CancellationToken token);
}