using ZendoAPI.Models.Domain;

namespace ZendoAPI.Repositories.Usuarios
{
    public interface IUserRepository
    {
        Task<IEnumerable<Usuario>> GetAllUsuarios();
        Task<Usuario?> GetUserById(Guid id);
        Task<Usuario?> GetUserByEmail(String email);
        Task<Usuario> CreateUser(Usuario usuario);
        Task<Usuario> UpdateUser(Usuario usuario);
        Task<bool> DeleteUser(Guid id);
        Task<bool> EmailExistente(string email);
    }
}
