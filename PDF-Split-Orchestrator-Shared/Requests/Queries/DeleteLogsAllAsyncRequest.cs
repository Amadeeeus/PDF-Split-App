using MediatR;
using PDF_Split_Orchestrator_Infrastructure.Repositories;
using PDF_Split_Orchestrator_Shared.Interfaces;

namespace PDF_Split_Orchestrator_Shared.Requests.Queries;

public class DeleteLogsAllAsyncRequest:IDeleteLogsRequest
{
    public async Task ExecuteAsync(ILogsRepository repository, CancellationToken token)
    {
        await repository.DeleteLogs_AllAsync();
        
    }
}