using ForensicBones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForensicBones.Controllers
{
    public class MarcadoresCraniosController : Controller
    {
        private readonly AppDbContext _context;
        public MarcadoresCraniosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.MarcadoresCranios.ToListAsync();
            return View(dados);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MarcadoresCranio marcadorescranio)
        {
            if (ModelState.IsValid)
            {
                _context.MarcadoresCranios.Add(marcadorescranio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.MarcadoresCranios.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.MarcadoresCranios.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.MarcadoresCranios.FindAsync(id);
            if (dados == null)
                return NotFound();

            _context.MarcadoresCranios.Remove(dados);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}