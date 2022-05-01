using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllActorsAsync();
        Task<T> GetActoryByIdAsync(int id);
        Task AddActorAsync(T entity);
        Task<T> UpdateActorAsync(int id, T entity);
        Task DeleteActorAsync(int id);
    }
}
