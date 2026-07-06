using Microsoft.EntityFrameworkCore;
using ZendoAPI.Data;
using ZendoAPI.Models.Domain;

namespace ZendoAPI.Repositories.Statuse
{
    public class SQLStatusRepository : IStatusRepository
    {
        private readonly ZendoDBContext dbContext;

        public SQLStatusRepository(ZendoDBContext dBContext)
        {
            this.dbContext = dBContext;
        }
        public async Task<IEnumerable<Status>> GetAllStatus()
        {
            return await dbContext.Statuses.ToListAsync();
        }

        public async Task<Status?> GetStatusById(Guid id)
        {
            return await dbContext.Statuses.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
