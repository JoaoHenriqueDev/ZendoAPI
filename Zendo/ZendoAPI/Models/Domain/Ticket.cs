using ZendoAPI.Models.Enum.ticket;

namespace ZendoAPI.Models.Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }
        private String titulo;
        private String descricao;
        private Guid categoriaId;
        private TicketPriorityEnum prioridade;
        private Guid statusId;
        private Guid usuarioId;
        private Guid? tecnicoId;
        private DateTime createdAt;
        private DateTime? updatedAt;
        private DateTime? closedAt;

        private Categoria categoria;
        private Status status;
        private Usuario usuario;
        private Usuario? tecnico;

        public String Titulo { get { return titulo; } set { titulo = value; } }
        public String Descricao { get { return descricao; } set { descricao = value; } }
        public Guid CategoriaId { get { return categoriaId; } set { categoriaId = value; } }
        public TicketPriorityEnum Prioridade { get { return prioridade; } set { prioridade = value; } }
        public Guid StatusId { get { return statusId; } set { statusId = value; } }
        public Guid UsuarioId { get { return usuarioId; } set { usuarioId = value; } }
        public Guid? TecnicoId { get { return tecnicoId; } set { tecnicoId = value; } }
        public DateTime CreatedAt { get { return createdAt; } set { createdAt = value; } }
        public DateTime? UpdatedAt { get { return updatedAt; } set { updatedAt = value; } }
        public DateTime? ClosedAt { get { return closedAt; } set { closedAt = value; } }
    }
}
