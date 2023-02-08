using Microsoft.EntityFrameworkCore;
using API.Models.DataModels;

namespace API.DataAccess;

public class UniversityDBContext : DbContext {
    
    public UniversityDBContext( DbContextOptions<UniversityDBContext> options ) : base(options) {}

    public DbSet<User> ? Users { get; set; }
    public DbSet<Curso> ? Cursos { get; set; } 
}