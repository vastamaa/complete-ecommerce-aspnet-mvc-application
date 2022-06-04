using eTickets.Data.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service) => _service = service;

        public async Task<IActionResult> Index() => View(await _service.GetAllAsync());
    }
}
