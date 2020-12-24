using Cursos.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace Cursos.Infra.Context
{
    public class AppDbContext : DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Cursos> Curso { get; set; }
    }
}