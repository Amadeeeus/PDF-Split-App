using Microsoft.AspNetCore.Mvc;

namespace PDF_Split_Orchestrator_Api.Controllers;


[ApiController]
[Route("pdf/[controller]")]
public class FIleController:ControllerBase
{
    private readonly ILogger<FIleController> _logger;
    private readonly IFileService _fileService;

    public FIleController(ILogger<FIleController> logger, IFileService fileService)
    {
        _logger = logger;
        _fileService = fileService;
    }

    [HttpGet("/logs")]
    public async Task<IActionResult> GetLogs_AllAsync()
    {
        return Ok(await _fileService.GetLogs_AllAsync());
    }

    [HttpGet("/logs/{id}")]
    public async Task<IActionResult> GetLogsByIdAsync(string id)
    {
        return Ok(await _fileService.GetLogsByIdAsync(id));
    }

    [HttpGet("/logs/{fileName}")]
    public async Task<IActionResult> GetLogsByFileNameAsync(string fileName)
    {
        return Ok(await _fileService.GetLogsByFileNameAsync(fileName));
    }

    [HttpGet("/logs/{date}")]
    public async Task<IActionResult> GetLogsByDateAsync(string date)
    {
        return Ok(await _fileService.GetLogsByDateAsync(date));
    }

    [HttpPost("/upload")]
    public async Task<IActionResult> UploadAsync()
    {
        return Ok(await _fileService.UploadAsync());
    }
    
    
}