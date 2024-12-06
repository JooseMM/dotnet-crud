namespace MasterNet.WebApi.Controllers;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using MasterNet.Application.Cursos.CursosCreate;

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
    public async Task<ActionResult<Guid>> CursoCreate([FromForm] CursoCreateRequest request, CancellationToken cancellationToken)
    {
	var command = new CursoCreateCommand.CursoCreateCommandRequest(request);
	var result = await _sender.Send(command);
	return Ok(result);
    }
}
