using eTickets.Data;
using eTickets.Data.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorsService;

        public ActorsController(IActorsService actorsService) => _actorsService = actorsService;

        public async Task<IActionResult> Index() => View(await _actorsService.GetAllActorsAsync());
    }
}
