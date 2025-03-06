using PDF_Split_Orchestrator_Infrastructure.Repositories;

namespace PDF_Split_Orchestrator_Shared.Requests.Queries;

public class DeleteLogsByIdAsyncRequest
{
    public Guid Id { get; set; }

    public async Task ExecuteAsync(ILogsRepository repository, CancellationToken token)
    {
        await repository.DeleteLogs_ByIdAsync(Id);
    }
}