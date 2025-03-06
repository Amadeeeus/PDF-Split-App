using Microsoft.Extensions.Logging;
using PDF_Split_Orchestrator_Api.DTOs;
using PDF_Split_Orchestrator_Shared.Interfaces;

namespace PDF_Split_Orchestrator_Application.Services;
public class FileService : IFileService
{
    private readonly ILogger<FileService> _logger;
    
    public FileService(ILogger<FileService> logger)
    {
        _logger = logger;
    }
    

    public async Task<string> UploadAsync(string fileName)
    {
        _logger.LogInformation("UploadAsync: upload file. Filename:{0}", fileName);
        return await;
    }
}