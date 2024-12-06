namespace MasterNet.Domain;

public class Precio : BaseEntity
{
    public string? Nombre {get;set;}
    public Decimal? PrecioActual {get;set;}
    public Decimal? PrecioPromocion {get;set;}
    public ICollection<Curso>? Cursos {get;set;}
    public ICollection<CursoPrecio>? CursoPrecios {get;set;}
}
