using CsvHelper;
using Moq;
using SharafDG.Application.Contracts.Infrastructure;
using SharafDG.Application.Features.Events.Queries.GetEventsExport;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharafDG.Application.UnitTests.Mocks
{
    public class CsvExporterMocks
    {
        public static Mock<ICsvExporter> GetCsvExporter()
        {
            var mockCsvExporter = new Mock<ICsvExporter>();
            mockCsvExporter.Setup(repo => repo.ExportEventsToCsv(It.IsAny<List<EventExportDto>>())).Returns(
                (List<EventExportDto> eventExportDtos) =>
                {
                    using var memoryStream = new MemoryStream();
                    using (var streamWriter = new StreamWriter(memoryStream))
                    {
                        using var csvWriter = new CsvWriter(streamWriter);
                        csvWriter.WriteRecords(eventExportDtos);
                    }

                    return memoryStream.ToArray();
                });
            return mockCsvExporter;
        }
    }
}
