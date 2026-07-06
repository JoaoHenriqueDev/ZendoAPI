using ZendoAPI.Models.Enum.ticket;

namespace ZendoAPI.Models.Dto
{
    public record TicketDto(Guid id, String titulo, String descricao, Guid categoriaId, TicketPriorityEnum prioridade, Guid statusId, Guid usuarioId, Guid? tecnicoId, DateTime? createdAt, DateTime? updatedAt, DateTime? closedAt)
    {
    }
}
