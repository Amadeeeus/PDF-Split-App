using PDF_Split_Orchestrator_Infrastructure.Repositories;

namespace PDF_Split_Orchestrator_Shared.Requests.Queries;

public class DeleteLogsByNameAsyncRequest
{
    public string Filename { get; set; }

    public async Task ExecuteAsync(ILogsRepository repository, CancellationToken token)
    {
        await repository.DeleteLogs_ByFileNameAsync(Filename);
    }
}