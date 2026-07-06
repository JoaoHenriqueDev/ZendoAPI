using ZendoAPI.Models.Domain;

namespace ZendoAPI.Repositories.Statuse
{
    public interface IStatusRepository
    {
        Task<Status?> GetStatusById(Guid id);
        Task<IEnumerable<Status>> GetAllStatus();
    }
}
