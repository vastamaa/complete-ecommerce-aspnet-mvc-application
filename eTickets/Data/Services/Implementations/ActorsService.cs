using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Implementations
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) => _context = context;

        public void AddActor(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteActor(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actor GetActoryById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllActorsAsync() => await _context.Actors.ToListAsync();

        public Actor UpdateActor(int id, Actor actor)
        {
            throw new System.NotImplementedException();
        }
    }
}
