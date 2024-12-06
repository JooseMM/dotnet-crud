namespace MasterNet.Persistence.Models;

using Microsoft.AspNetCore.Identity;

public class AppUsers : IdentityUser
{
    public string? NombreCompleto {get;set;}
    public string? Carrera {get;set;}
}
