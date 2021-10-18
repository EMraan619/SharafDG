using SharafDG.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace SharafDG.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
