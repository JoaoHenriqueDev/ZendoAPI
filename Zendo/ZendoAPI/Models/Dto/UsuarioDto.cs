using ZendoAPI.Models.Enum.user;

namespace ZendoAPI.Models.Dto
{
    public record UsuarioDto(Guid id, String name, String email, UserEnum role, UserStatusEnum isActive, DateTime createdAt, DateTime? updatedAt)
    {
    }
}
