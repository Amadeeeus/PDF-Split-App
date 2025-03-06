using System.Collections;
using PDF_Split_Orchestrator_Infrastructure.Repositories;
using PDF_Split_Orchestrator_Shared.Entities;
using PDF_Split_Orchestrator_Shared.Interfaces;

namespace PDF_Split_Orchestrator_Shared.Requests.Commands;

public class GetLogsAllAsyncRequest:IGetLogsRequest<IEnumerable<LogEntity>>
{
    public async Task<IEnumerable<LogEntity>> ExecuteAsync(ILogsRepository repository, CancellationToken token)
    {
      return  await repository.GetLogs_AllAsync();
    }
}