using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using ZendoAPI.Data;
using ZendoAPI.Models.Domain;

namespace ZendoAPI.Repositories.Tickets
{
    public class SQLTicketRepository : ITicketRepository
    {
        private readonly ZendoDBContext dbContext;

        public SQLTicketRepository(ZendoDBContext dBContext)
        {
            this.dbContext = dBContext;
        }
        public async Task<int> CountTicket()
        {
            return await dbContext.Tickets.CountAsync();
        }

        public async Task<Ticket> CreateTicket(Ticket ticket)
        {
            await dbContext.Tickets.AddAsync(ticket);
            await dbContext.SaveChangesAsync();
            return ticket;
        }

        public async Task<bool> DeleteTicket(Guid id)
        {
            var ticketExistente = await dbContext.Tickets.FirstOrDefaultAsync(x => x.Id == id);
            if(ticketExistente == null)
            {
                return false;
            }
            dbContext.Tickets.Remove(ticketExistente);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Ticket>> GetAllTicket()
        {
            return await dbContext.Tickets.ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketByCategoria(Guid categoriaId)
        {
            return await dbContext.Tickets
                .Where(x => x.CategoriaId == categoriaId)
                .ToListAsync();
        }

        public async Task<Ticket?> GetTicketById(Guid id)
        {
            return await dbContext.Tickets.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Ticket>> GetTicketByStatus(Guid statusId)
        {
            return await dbContext.Tickets
                .Where(x => x.StatusId == statusId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketByTecnico(Guid userId)
        {
            return await dbContext.Tickets
                .Where(x => x.TecnicoId == userId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketByUsuario(Guid userId)
        {
            return await dbContext.Tickets
                .Where(x => x.UsuarioId == userId)
                .ToListAsync();
        }

        public async Task UpdateTicket(Ticket ticket)
        {
            var ticketExistente = await dbContext.Tickets.FirstOrDefaultAsync(x => x.Id == ticket.Id);
            if (ticketExistente == null)
            {
              
            }
            dbContext.Tickets.Entry(ticketExistente).CurrentValues.SetValues(ticket);
            await dbContext.SaveChangesAsync();
        }
    }
}
