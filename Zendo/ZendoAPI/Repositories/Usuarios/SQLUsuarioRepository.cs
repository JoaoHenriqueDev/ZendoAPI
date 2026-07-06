using Microsoft.EntityFrameworkCore;
using ZendoAPI.Data;
using ZendoAPI.Models.Domain;

namespace ZendoAPI.Repositories.Usuarios
{
    public class SQLUsuarioRepository : IUserRepository
    {
        private readonly ZendoDBContext dbContext;

        public SQLUsuarioRepository(ZendoDBContext dBContext)
        {
            this.dbContext = dBContext;
        }

        public async Task<Usuario> CreateUser(Usuario usuario)
        {
            await dbContext.Usuarios.AddAsync(usuario);
            await dbContext.SaveChangesAsync();
            return usuario;
        }

        public async Task DeleteUser(Guid id)
        {
            var usuario = await dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            if(usuario == null)
            {
            
            }
            dbContext.Usuarios.Remove(usuario);
       
        }

        public async Task<bool> EmailExistente(string email)
        {
            var usuario = await dbContext.Usuarios.FirstOrDefaultAsync(x => x.Email == email);
            if(usuario == null)
            {
                return false;
            }
            return true;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuarios()
        {
           return await dbContext.Usuarios.ToListAsync();
        }

        public async Task<Usuario?> GetUserByEmail(string email)
        {
            return await dbContext.Usuarios.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<Usuario> GetUserById(Guid id)
        {
            return await dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Usuario> UpdateUser(Usuario usuario)
        {
            var usuarioExistente = await dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == usuario.Id);
            if (usuarioExistente == null)
            {
                return null;
            }
            dbContext.Usuarios.Entry(usuarioExistente).CurrentValues.SetValues(usuario);
            await dbContext.SaveChangesAsync();
            return usuario;
        }

    }
}
