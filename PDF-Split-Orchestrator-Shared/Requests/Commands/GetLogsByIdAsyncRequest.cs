using System.Collections;
using PDF_Split_Orchestrator_Infrastructure.Repositories;
using PDF_Split_Orchestrator_Shared.Entities;

namespace PDF_Split_Orchestrator_Shared.Requests.Commands;

public class GetLogsByIdAsyncRequest
{
    public Guid Id { get; set; }

    public GetLogsByIdAsyncRequest(Guid id)
    {
        Id = id;
    }

    public async Task<IEnumerable<LogEntity>> ExecuteAsync(ILogsRepository repository, CancellationToken token)
    {
        return await repository.GetLogs_ByIdAsync(Id);
    }
}