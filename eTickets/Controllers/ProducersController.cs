using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _producersService;

        public ProducersController(IProducersService producersService)
        {
            _producersService = producersService;
        }

        public async Task<IActionResult> Index() => View(await _producersService.GetAllAsync());

        //GET: producers/detail/1

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _producersService.GetByIdAsync(id);
            if (producerDetails is null) return View("NotFound");
            return View(producerDetails);
        }

        //GET: producers/create
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL, FullName, Biography")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            await _producersService.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //GET: producers/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _producersService.GetByIdAsync(id);

            if (producerDetails is null) return View("NotFound");

            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, ProfilePictureURL, FullName, Biography")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            if (id == producer.Id)
            {
                await _producersService.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }

        //DELETE: producers/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _producersService.GetByIdAsync(id);

            if (producerDetails is null) return View("Not found!");

            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _producersService.GetByIdAsync(id);
            if (!ModelState.IsValid) return View("Not found!");

            await _producersService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
