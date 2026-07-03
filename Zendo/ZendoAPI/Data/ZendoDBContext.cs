using Microsoft.EntityFrameworkCore;
using ZendoAPI.Models.Domain;

namespace ZendoAPI.Data
{
    public class ZendoDBContext: DbContext
    {
        public ZendoDBContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


    }
}
