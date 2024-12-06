using MediatR;
using MasterNet.Persistence;
using MasterNet.Domain;

namespace MasterNet.Application.Cursos.CursosCreate;

public class CursoCreateCommand
{
    public record CursoCreateCommandRequest(CursoCreateRequest cursoCreateRequest)
    : IRequest<Guid>;

    internal class CursoCreateCommandHandler 
    : IRequestHandler<CursoCreateCommandRequest, Guid>
    {
	private readonly MasterNetDbContext _context;

	public CursoCreateCommandHandler(MasterNetDbContext context)
	{
	    this._context = context;
	}

	public async Task<Guid> Handle(
		CursoCreateCommandRequest request,
		CancellationToken cancellationToken
	    )
	{
	    var curso = new Curso {
		Id = Guid.NewGuid(),
		Titulo = request.cursoCreateRequest.Titulo,
		Descripcion = request.cursoCreateRequest.Titulo,
		FechaPublicacion = request.cursoCreateRequest.FechaPublicacion
	    };

	    _context.Add(curso);
	    await _context.SaveChangesAsync(cancellationToken);

	    return curso.Id;
	}

    }
}
