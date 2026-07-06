using Microsoft.EntityFrameworkCore;
using ZendoAPI.Data;
using ZendoAPI.Models.Domain;

namespace ZendoAPI.Repositories.Categorias
{
    public class SQLCategoriaRepository : ICategoriaRepository
    {
        private readonly ZendoDBContext dbContext;

        public SQLCategoriaRepository(ZendoDBContext dBContext)
        {
            this.dbContext = dBContext;
        }
        public async Task<Categoria> CreateCategoria(Categoria categoria)
        {
            await dbContext.Categorias.AddAsync(categoria);
            await dbContext.SaveChangesAsync();
            return categoria;
        }

        public async Task<IEnumerable<Categoria>> GetCategoriaAll()
        {
            return await dbContext.Categorias.ToListAsync();
        }

        public async Task<Categoria?> GetCategoriaById(Guid id)
        {
            return await dbContext.Categorias.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> RemoveCategoria(Guid id)
        {
            var categoriaExistente = await dbContext.Categorias.FirstOrDefaultAsync(x => x.Id == id);
            if (categoriaExistente == null)
            {
                return false;
            }
            dbContext.Categorias.Remove(categoriaExistente);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
