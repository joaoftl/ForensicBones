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

        // Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.InventariosCranio.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, InventarioCranio inventarioCranio)
        {
            if (id != inventarioCranio.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.InventariosCranio.Update(inventarioCranio);
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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.InventariosCranio.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.InventariosCranio.FindAsync(id);
            if (dados == null)
                return NotFound();

            _context.InventariosCranio.Remove(dados);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
