namespace MasterNet.Application.Cursos.CursosCreate;
using Microsoft.AspNetCore.Http;

public class  CursoCreateRequest
{
    public string? Titulo {get;set;}
    public string? Descripcion {get;set;}
    public DateTime? FechaPublicacion {get;set;}
    public IFormFile? Foto {get;set;}
    public Guid? InstructorID {get;set;}
    public Guid? PrecioID {get;set;}
}
