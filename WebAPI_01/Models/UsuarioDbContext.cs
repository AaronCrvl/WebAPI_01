using Microsoft.EntityFrameworkCore;

namespace WebAPI_01.Models
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
