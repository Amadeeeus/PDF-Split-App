

using PDF_Split_Orchestrator_Api.DTOs;

namespace PDF_Split_Orchestrator_Shared.Interfaces;

public interface IFileService
{
    
    Task<string> UploadAsync(string fileName);
}