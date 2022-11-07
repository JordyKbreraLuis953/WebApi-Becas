using Microsoft.EntityFrameworkCore;
using Becas.Models;


namespace Becas{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base (options)
        {
        }

        public DbSet<Alumno> Alumnos {get; set;}
        
    } 
} 