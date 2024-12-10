namespace MasterNet.WebApi.Controllers;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using MasterNet.Application.Cursos.CursosCreate;
using MasterNet.Application.Cursos.CursosReporteExcel;
using MasterNet.Application.Core;
[ApiController]
[Route("api/cursos")]
public class CursosControllers : ControllerBase
{
    private readonly ISender _sender;

    public CursosControllers(ISender sender)
    {
	_sender = sender;
    }

    [HttpPost("create")]
    public async Task<ActionResult<Result<Guid>>> CursoCreate([FromForm] CursoCreateRequest request, CancellationToken cancellationToken)
    {
	var command = new CursoCreateCommand.CursoCreateCommandRequest(request);
	return await _sender.Send(command);
    }

    [HttpGet("reporte")]
    public async Task<IActionResult> ReportCSV(CancellationToken cancellationToken)
    {
	var query = new CursoReporteExcelQuery.CursoReporteExcelQueryRequest();
	var resultado = await _sender.Send(query, cancellationToken);

	if(resultado is null)
	{
	    return Ok("No data was found, there's no need for a csv file");
	}

	byte[] excelBytes =  ((MemoryStream) resultado).ToArray();
	return File(excelBytes, "text/csv", "cursos.csv");
    }
}
