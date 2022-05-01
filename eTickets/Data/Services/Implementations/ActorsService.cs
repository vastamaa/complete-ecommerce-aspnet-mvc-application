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

        public async Task AddActorAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteActorAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> GetActoryByIdAsync(int id) => await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);

        public async Task<IEnumerable<Actor>> GetAllActorsAsync() => await _context.Actors.ToListAsync();

        public async Task<Actor> UpdateActorAsync(int id, Actor actor)
        {
            _context.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
        }
    }
}
