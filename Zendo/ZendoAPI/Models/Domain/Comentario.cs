namespace ZendoAPI.Models.Domain
{
    public class Comentario
    {
        public Guid Id { get; set; }
        private Guid ticketId;
        private Guid autorId;
        private String mensagem;
        private DateTime createdAt;

        private Ticket ticket;
        private Usuario autor;

        public Guid TicketId { get { return ticketId; } set { ticketId = value; } }
        public Guid AutorId { get { return autorId; } set{ autorId = value; }}
        public String Mensagem { get { return mensagem; }  set { mensagem = value; } }
        public DateTime CreatedAt { get { return createdAt; } set { createdAt = value; } }
    }
}
