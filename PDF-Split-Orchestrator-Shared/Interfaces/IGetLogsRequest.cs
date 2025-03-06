using System.Collections;
using MediatR;
using PDF_Split_Orchestrator_Infrastructure.Repositories;
using PDF_Split_Orchestrator_Shared.Entities;

namespace PDF_Split_Orchestrator_Shared.Interfaces;

public interface IGetLogsRequest<T>:IRequest<IEnumerable<LogEntity>>
{
    Task<IEnumerable<LogEntity>> ExecuteAsync(ILogsRepository repository, CancellationToken cancellationToken);
}