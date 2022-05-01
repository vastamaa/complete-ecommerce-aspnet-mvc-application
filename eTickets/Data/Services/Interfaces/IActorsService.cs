using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Interfaces
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActorsAsync();
        Task<Actor> GetActoryByIdAsync(int id);
        Task AddActorAsync(Actor actor);
        Task<Actor> UpdateActorAsync(int id, Actor actor);
        Task DeleteActorAsync(int id);
    }
}
