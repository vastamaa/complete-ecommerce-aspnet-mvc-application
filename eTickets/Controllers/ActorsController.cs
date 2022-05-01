using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Biography")] Actor actor)
        {
            if (!ModelState.IsValid) return View(actor);

            await _actorsService.AddActorAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //GET: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actorsService.GetActoryByIdAsync(id);

            if (actorDetails is null) return View("Not found!");

            return View(actorDetails);
        }

        //UPDATE: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _actorsService.GetActoryByIdAsync(id);

            if (actorDetails is null) return View("Not found!");

            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor)
        {
            if (!ModelState.IsValid) return View(actor);

            await _actorsService.UpdateActorAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //DELETE: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actorsService.GetActoryByIdAsync(id);

            if (actorDetails is null) return View("Not found!");

            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _actorsService.GetActoryByIdAsync(id);
            if (!ModelState.IsValid) return View("Not found!");

            await _actorsService.DeleteActorAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
