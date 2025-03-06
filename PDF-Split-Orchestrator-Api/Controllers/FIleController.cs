using MediatR;
using Microsoft.AspNetCore.Mvc;
using PDF_Split_Orchestrator_Shared.Interfaces;
using PDF_Split_Orchestrator_Shared.Requests.Commands;
using PDF_Split_Orchestrator_Shared.Requests.Queries;

namespace PDF_Split_Orchestrator_Api.Controllers;


[ApiController]
[Route("pdf/[controller]")]
public class FIleController:ControllerBase
{
    private readonly ILogger<FIleController> _logger;
    private readonly IFileService _fileService;
    private readonly IMediator _mediator;
    public FIleController(ILogger<FIleController> logger, IFileService fileService, IMediator mediator)
    {
        _logger = logger;
        _fileService = fileService;
        _mediator = mediator;
    }

    [HttpGet("/logs")]
    public async Task<IActionResult> GetLogs_AllAsync()
    {
        _logger.LogInformation("Getting logs from PDF");
        return Ok(await _mediator.Send(new GetLogsAllAsyncRequest()));
    }
    
    [HttpGet("/logs/{id}")]
    public async Task<IActionResult> GetLogsByIdAsync(Guid id)
    {
        _logger.LogInformation($"Getting logs by id: {id}");
        return Ok(await _mediator.Send(new GetLogsByIdAsyncRequest(id)));
    }

    [HttpGet("/logs/{fileName}")]
    public async Task<IActionResult> GetLogsByFileNameAsync(string fileName)
    {   
        _logger.LogInformation($"Getting logs by fileName: {fileName}");
        return Ok(await _mediator.Send(new GetLogsByFileNameAsyncRequest(fileName)));
    }

    [HttpGet("/logs/{date}")]
    public async Task<IActionResult> GetLogsByDateAsync(DateTime date)
    {
        return Ok(await _mediator.Send(new GetLogsByDateAsyncRequest(date)));
    }
    
    [HttpDelete("/deletelogs")]
    public async Task<IActionResult> DeleteLogs_AllAsync(CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new DeleteLogsAllAsyncRequest(), cancellationToken));
    }
    
    [HttpDelete("/logs/delete/{id}")]
    public async Task<IActionResult> DeleteLogsByIdAsync(Guid id)
    {
        return Ok(await _mediator.Send(new DeleteLogsByIdAsyncRequest{Id = id}));
    }

    [HttpGet("/logs/delete/{fileName}")]
    public async Task<IActionResult> DeleteLogsByFileNameAsync(string fileName)
    {
        return Ok(await _mediator.Send(new DeleteLogsByNameAsyncRequest{Filename = fileName}));
    }

    [HttpGet("/logs/delete/{date}")]
    public async Task<IActionResult> DeleteLogsByDateAsync(DateTime date)
    {
        return Ok(await _mediator.Send(new DeleteLogsByDateAsync{Date = date}));
    }
    [HttpPost("/upload")]
    public async Task<IActionResult> UploadAsync(string file)
    {
        return Ok(await _fileService.UploadAsync(file));
    }
}