using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Interfaces
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActorsAsync();
        Actor GetActoryById(int id);
        void AddActor(Actor actor);
        Actor UpdateActor(int id, Actor actor);
        void DeleteActor(int id);
    }
}
