using ZendoAPI.Models.Domain;

namespace ZendoAPI.Repositories.Categorias
{
    public interface ICategoriaRepository
    {
        Task<Categoria?> GetCategoriaById(Guid id);
        Task<IEnumerable<Categoria>> GetCategoriaAll();
        Task<Categoria> CreateCategoria(Categoria categoria);
        Task<bool> RemoveCategoria(Guid id);
    }
}
