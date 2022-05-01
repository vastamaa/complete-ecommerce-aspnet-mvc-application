using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        public Task AddActorAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteActorAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> GetActoryByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllActorsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<T> UpdateActorAsync(int id, T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
