

namespace PDF_Split_Orchestrator_Application.Services;

public interface IFIleService
{
    Task<List<LogDto>> GetLogs_AllAsync();
    Task<List<LogDto>> GetLogsByIdAsync(string id);
    Task<List<LogDto>> GetLogsByFileNameAsync(string fileName);
    Task<List<LogDto>> GetLogsByDateAsync(string date);
    Task<string> UploadAsync(string fileName);
}