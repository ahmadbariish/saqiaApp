using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuqyaWaterSystem.Data;
using SuqyaWaterSystem.Models;

namespace SuqyaWaterSystem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _context.Customers.Include(c => c.Area).ToListAsync();
            return View(customers);
        }

        public IActionResult Create()
        {
            ViewBag.Areas = _context.Areas.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Areas = _context.Areas.ToList();
                return View(customer);
            }

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
