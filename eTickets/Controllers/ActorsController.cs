using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service) => _service = service;

        public async Task<IActionResult> Index() => View(await _service.GetAllAsync());

        //GET: Actors/Create
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Biography")] Actor actor)
        {
            if (!ModelState.IsValid) return View(actor);

            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //GET: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails is null) return View("NotFound!");

            return View(actorDetails);
        }

        //UPDATE: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails is null) return View("NotFound!");

            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor)
        {
            if (!ModelState.IsValid) return View(actor);

            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //DELETE: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails is null) return View("NotFound!");

            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (!ModelState.IsValid) return View("NotFound!");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
