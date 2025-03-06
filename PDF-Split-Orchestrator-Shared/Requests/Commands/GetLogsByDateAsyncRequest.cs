using System.Collections;
using MediatR;
using PDF_Split_Orchestrator_Infrastructure.Repositories;
using PDF_Split_Orchestrator_Shared.Entities;
using PDF_Split_Orchestrator_Shared.Interfaces;

namespace PDF_Split_Orchestrator_Shared.Requests.Commands;

public class GetLogsByDateAsyncRequest:IGetLogsRequest<DateTime>
{
    public DateTime Date { get; set; }

    public GetLogsByDateAsyncRequest(DateTime date)
    {
        Date = date;
    }

    public async Task<IEnumerable<LogEntity>> ExecuteAsync(ILogsRepository repository, CancellationToken token)
    {
       return await repository.GetLogs_ByDateAsync(Date);
    }
}