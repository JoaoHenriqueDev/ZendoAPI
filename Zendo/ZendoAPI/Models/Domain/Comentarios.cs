namespace ZendoAPI.Models.Domain
{
    public class Comentarios
    {
        private Guid id;
        private Guid ticketId;
        private Guid autorId;
        private String mensagem;
        private DateTime createdAt;

        private Tickets ticket;
        private Users autor;

        public Guid Id { get { return id; } }
        public Guid TicketId { get { return ticketId; } }
        public Guid AutorId { get { return autorId; } }
        public String Mensagem { get { return mensagem; } }
        public DateTime CreatedAt { get { return createdAt; } }
    }
}
