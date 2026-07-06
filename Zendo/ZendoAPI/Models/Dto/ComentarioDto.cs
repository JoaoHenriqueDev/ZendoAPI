namespace ZendoAPI.Models.Dto
{
    public record ComentarioDto(Guid id, Guid ticketId, Guid autoId, String mensagem, DateTime createdAt)
    {
    }
}
