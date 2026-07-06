using Microsoft.EntityFrameworkCore;
using ZendoAPI.Data;
using ZendoAPI.Models.Domain;

namespace ZendoAPI.Repositories.Comentarios
{
    public class SQLComentarioRepository : IComentarioRepository
    {
        private readonly ZendoDBContext dbContext;

        public SQLComentarioRepository(ZendoDBContext dBContext)
        {
            this.dbContext = dBContext;
        }
        public async Task<Comentario> CreateComentario(Comentario comentario)
        {
            await dbContext.Comentarios.AddAsync(comentario);
            await dbContext.SaveChangesAsync();
            return comentario;
        }

        public async Task<bool> DeleteComentario(Guid id)
        {
            var comentarioExistente = await dbContext.Comentarios.FirstOrDefaultAsync(x => x.Id == id);
            if(comentarioExistente == null)
            {
                return false;
            }
            dbContext.Comentarios.Remove(comentarioExistente);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Comentario?> GetById(Guid id)
        {
            return await dbContext.Comentarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Comentario>> GetByTicket(Guid ticketId)
        {
            return await dbContext.Comentarios.
                Where(x => x.TicketId == ticketId).
                ToListAsync();
        }
    }
}
