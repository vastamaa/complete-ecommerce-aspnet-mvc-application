﻿using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context) => _context = context;

        public async Task<IActionResult> Index() => View(await _context.Movies
            .Include(m => m.Cinema)
            .OrderBy(n => n.Name)
            .ToListAsync());
    }
}
