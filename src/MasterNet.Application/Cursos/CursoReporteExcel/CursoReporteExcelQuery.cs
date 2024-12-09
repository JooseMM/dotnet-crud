namespace MasterNet.Application.Cursos.CursosReporteExcel;

using MediatR;
using MasterNet.Persistence;
using Microsoft.EntityFrameworkCore;
using MasterNet.Domain;
using MasterNet.Application.Interfaces;

public class CursoReporteExcelQuery
{
    public record CursoReporteExcelQueryRequest : IRequest<MemoryStream>;

    internal class CursoReporteExcelQueryHandler : IRequestHandler<CursoReporteExcelQueryRequest, MemoryStream>
    {
	private readonly MasterNetDbContext _context;
	private readonly IReportService<Curso> _reportService;

	public CursoReporteExcelQueryHandler(
		MasterNetDbContext context,
		IReportService<Curso> reportService
	    ) 
	{
	    _context = context;
	    _reportService = reportService;
	}

	public async Task<MemoryStream> Handle(
		CursoReporteExcelQueryRequest request,
		CancellationToken cancellationToken
		)
	{
	    var cursos = await _context.Cursos!.Take(10).Skip(0).ToListAsync();

	    return await _reportService.GetCsvReport(cursos);
	}
    }
}
