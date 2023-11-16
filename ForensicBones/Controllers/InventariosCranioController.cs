using ForensicBones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForensicBones.Controllers
{
    public class InventariosCranioController : Controller
    {
        private readonly AppDbContext _context;
        public InventariosCranioController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.InventariosCranio.ToListAsync();
            return View(dados);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(InventarioCranio inventariocranio)
        {
            if (ModelState.IsValid)
            {
                _context.InventariosCranio.Add(inventariocranio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.InventariosCranio.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }
    }
}
