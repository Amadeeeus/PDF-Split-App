using AutoMapper;
using PDF_Split_Orchestrator_Shared.Entities;

namespace PDF_Split_Orchestrator_Infrastructure.Repositories;
using MongoDB.Driver;

public class LogsRepository : ILogsRepository
{
    private readonly IMongoCollection<LogEntity> _log;
    private readonly IMapper _mapper;

    public LogsRepository(IMongoCollection<LogEntity> log, IMapper mapper)
    {
        _mapper = mapper;
        _log = log;
    }

    public async Task CreateLogAsync(LogEntity logEntity, CancellationToken cancellationToken)
    {
        await _log.InsertOneAsync(_mapper.Map<LogEntity>(logEntity),null, cancellationToken);
    }

    public async Task<IEnumerable<LogEntity>> GetLogs_AllAsync()
    {
        return await _log.FindAsync(FilterDefinition<LogEntity>.Empty).Result.ToListAsync();
    }

    public async Task<IEnumerable<LogEntity>> GetLogs_ByIdAsync(Guid userId)
    {
        return await _log.FindAsync(x=>x.Id == userId).Result.ToListAsync();
    }

    public async Task<IEnumerable<LogEntity>> GetLogs_ByFileNameAsync(string fileName)
    {
        return await _log.FindAsync(x=>x.FileName == fileName).Result.ToListAsync();
    }

    public async Task<IEnumerable<LogEntity>> GetLogs_ByDateAsync(DateTime date)
    {
        return await _log.FindAsync(x=>x.Date == date).Result.ToListAsync();
    }

    public async Task DeleteLogs_AllAsync()
    {
        await _log.DeleteManyAsync(FilterDefinition<LogEntity>.Empty);
    }

    public async Task DeleteLogs_ByIdAsync(Guid userId)
    {
       await _log.DeleteManyAsync(x=>x.Id == userId);
    }

    public async Task DeleteLogs_ByFileNameAsync(string fileName)
    {
        await _log.DeleteManyAsync(x=>x.FileName == fileName);
    }

    public async Task DeleteLogs_ByDateAsync(DateTime date)
    {
        await _log.DeleteManyAsync(x=>x.Date == date);
    }
}