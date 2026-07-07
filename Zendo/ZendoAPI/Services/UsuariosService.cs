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
        public Task<bool> emailUsuarioExistente(String email)
        {
            var emailExistente = repository.EmailExistente(email);
            return emailExistente;
        }
        public IEnumerable<UsuarioDto> getAllUsuarios()
        {
            var usuarios = repository.GetAllUsuarios();
            var usuariosDTO = mapper.Map<IEnumerable<UsuarioDto>>(usuarios);
            return usuariosDTO;
        }
        public UsuarioDto getUsuarioByEmail(String email)
        {
            return mapper.Map<UsuarioDto>(repository.GetUserByEmail(email));
        }

        public UsuarioDto getUsuarioById(Guid id)
        {
            return mapper.Map<UsuarioDto>(repository.GetUserById(id));
        }
        public UsuarioDto updateUsuario(UsuarioDto usuarioDtoRequest)
        {
            var usuario = mapper.Map<Usuario>(usuarioDtoRequest);
            var usuarioDtoResponse = mapper.Map<UsuarioDto>(repository.UpdateUser(usuario));
            return usuarioDtoResponse;
        }


    }
}
