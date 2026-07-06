using AutoMapper;
using ZendoAPI.Models.Domain;
using ZendoAPI.Models.Dto;
using ZendoAPI.Repositories.Usuarios;

namespace ZendoAPI.Services
{
    public class UsuariosService
    {
        private readonly SQLUsuarioRepository repository;
        private readonly IMapper mapper;
        public UsuariosService(SQLUsuarioRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public UsuarioDto criarUsuario(Usuario usuario)
        {
            var novoUsuario = repository.CreateUser(usuario);
            return mapper.Map<UsuarioDto>(novoUsuario);
        }
        public void deleteUsuario(Guid id)
        {
            var respostaDeleteUser = repository.DeleteUser(id);
        }
    }
}
