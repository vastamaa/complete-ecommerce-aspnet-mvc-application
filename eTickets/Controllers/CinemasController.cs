using eTickets.Data.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _cinemasService;

        public CinemasController(ICinemasService cinemasService) => _cinemasService = cinemasService;

        public async Task<IActionResult> Index() => View(await _cinemasService.GetAllAsync());
    }
}
