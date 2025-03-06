using PDF_Split_Orchestrator_Infrastructure.Repositories;
using PDF_Split_Orchestrator_Shared.Entities;

namespace PDF_Split_Orchestrator_Shared.Requests.Commands;

public class GetLogsByFileNameAsyncRequest
{
    public string FileName { get; set; }

    public GetLogsByFileNameAsyncRequest(string fileName)
    {
        FileName = fileName;
    }

    public async Task<IEnumerable<LogEntity>> ExecuteAsync(ILogsRepository repository, CancellationToken token)
    {
        return await repository.GetLogs_ByFileNameAsync(FileName);
    }
}