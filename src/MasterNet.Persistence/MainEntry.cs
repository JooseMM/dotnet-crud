/*
using MasterNet.Persistence;
using MasterNet.Domain;
using Microsoft.EntityFrameworkCore;

using var context = new MasterNetDbContext();

var curso = new Curso {
    Id  = Guid.NewGuid(),
    Titulo = "Programacion en C#",
    Descripcion = "Las Bases de la programacion",
    FechaPublicacion = DateTime.Now
};

context.Add(curso);
await context.SaveChangesAsync();

var cursos = await context.Cursos!.ToListAsync();


foreach(var item in cursos) 
{
    Console.WriteLine($"Curso -> {item.Titulo} id -> {item.Id}");
}
*/
