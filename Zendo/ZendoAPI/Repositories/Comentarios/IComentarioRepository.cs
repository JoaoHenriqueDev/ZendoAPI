using ZendoAPI.Models.Domain;

namespace ZendoAPI.Repositories.Comentarios
{
    public interface IComentarioRepository
    {
        Task<Comentario?> GetById(Guid id);
        Task<IEnumerable<Comentario>> GetByTicket(Guid ticketId);
        Task<Comentario> CreateComentario(Comentario comentario);
        Task<bool> DeleteComentario(Guid id);
    }
}
