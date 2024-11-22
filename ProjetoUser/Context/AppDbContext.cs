using Microsoft.EntityFrameworkCore;
using ProjetoUser.Model;

namespace ProjetoUser.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {
            
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        //public DbSet<UsuarioAPIToken> UsuarioAPIs { get; set; }
    }
}
