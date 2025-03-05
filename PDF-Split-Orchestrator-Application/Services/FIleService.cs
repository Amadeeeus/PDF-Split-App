using Microsoft.Extensions.Logging;
using PDF_Split_Orchestrator_Api.DTOs;

namespace PDF_Split_Orchestrator_Application.Services;
public class FIleService : IFIleService
{
    private readonly IFileRepository _fileRepository;
    private readonly ILogger<FIleService> _logger;
    
    public FIleService(IFileRepository fileRepository, ILogger<FIleService> logger)
    {
        _fileRepository = fileRepository;
        _logger = logger;
    }

    public async Task<List<LogDto>> GetLogs_AllAsync()
    {
        
    }

    public async Task<List<LogDto>> GetLogsByIdAsync(string id)
    {
        
    }

    public async Task<List<LogDto>> GetLogsByFileNameAsync(string fileName)
    {
        
    }

    public async Task<List<LogDto>> GetLogsByDateAsync(string date)
    {
        
    }

    public async Task<string> UploadAsync(string fileName)
    {
        
    }

}