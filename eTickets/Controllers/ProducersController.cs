using eTickets.Data.Services.Interfaces;
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
    }
}
