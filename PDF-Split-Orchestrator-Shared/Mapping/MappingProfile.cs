using AutoMapper;
using PDF_Split_Orchestrator_Shared.Entities;

namespace PDF_Split_Orchestrator_Shared.Mapping;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<LogEntity, MongoLogEntity>()
            .ForMember(x => x.Date, opt => opt.MapFrom(y => y.Date))
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.FileName, opt => opt.MapFrom(y => y.FileName));
    }
}