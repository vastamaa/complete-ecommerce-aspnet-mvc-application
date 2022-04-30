using eTickets.Data;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
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

        //GET: Actors/Create
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Biography")]Actor actor)
        {
            if (!ModelState.IsValid) return View(actor);

            _actorsService.AddActor(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
