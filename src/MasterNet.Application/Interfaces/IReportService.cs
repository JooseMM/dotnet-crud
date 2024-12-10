namespace MasterNet.Application.Interfaces;

using MasterNet.Domain;

public interface IReportService<T> where T : BaseEntity
{
    Task<MemoryStream> GetCsvReport(List<T> records);
}
