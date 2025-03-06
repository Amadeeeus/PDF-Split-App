using PDF_Split_Orchestrator_Shared.Entities;

namespace PDF_Split_Orchestrator_Infrastructure.Repositories;

public interface ILogsRepository
{
    Task CreateLogAsync(LogEntity logEntity, CancellationToken cancellationToken);
    Task<IEnumerable<LogEntity>> GetLogs_AllAsync();
    Task<IEnumerable<LogEntity>> GetLogs_ByIdAsync(Guid userId);
    Task<IEnumerable<LogEntity>> GetLogs_ByFileNameAsync(string fileName);
    Task<IEnumerable<LogEntity>> GetLogs_ByDateAsync(DateTime date);
    Task DeleteLogs_AllAsync();
    Task DeleteLogs_ByIdAsync(Guid userId);
    Task DeleteLogs_ByFileNameAsync(string fileName);
    Task DeleteLogs_ByDateAsync(DateTime date);
}