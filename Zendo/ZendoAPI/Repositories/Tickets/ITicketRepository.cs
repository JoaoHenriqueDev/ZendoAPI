using ZendoAPI.Models.Domain;

namespace ZendoAPI.Repositories.Tickets
{
    public interface ITicketRepository
    {
        Task<Ticket?> GetTicketById(Guid id);
        Task<IEnumerable<Ticket>> GetAllTicket();
        Task<IEnumerable<Ticket>> GetTicketByUsuario(Guid userId);
        Task<IEnumerable<Ticket>> GetTicketByTecnico(Guid userId);
        Task<IEnumerable<Ticket>> GetTicketByStatus(Guid statusId);
        Task<IEnumerable<Ticket>> GetTicketByCategoria(Guid categoriaId);
        Task<Ticket> CreateTicket(Ticket ticket);
        Task UpdateTicket(Ticket ticket);
        Task<bool> DeleteTicket(Guid id);
        Task<int> CountTicket();

    }
}
