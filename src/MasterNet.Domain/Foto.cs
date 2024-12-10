namespace MasterNet.Domain;

public class Foto : BaseEntity 
{
    public string? url {get;set;}
    public Guid? CursoId {get;set;}
    public Curso? Curso {get;set;}
}
