using eTickets.Data.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext context) : base(context) { }
    }
}
