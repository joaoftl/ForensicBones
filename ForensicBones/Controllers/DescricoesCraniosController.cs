using ForensicBones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForensicBones.Controllers
{
    public class DescricoesCraniosController : Controller
    {
        private readonly AppDbContext _context;
        public DescricoesCraniosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.DescricoesCranios.ToListAsync();
            return View(dados);
        }
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DescricaoCranio descricaocranio)
        {
            if (ModelState.IsValid) 
            {
                _context.DescricoesCranios.Add(descricaocranio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        { 
            if(id == null)
                return NotFound();

            var dados = await _context.DescricoesCranios.FindAsync(id);
            if(dados == null) 
                return NotFound();

            return View(dados);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.DescricoesCranios.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.DescricoesCranios.FindAsync(id);
            if (dados == null)
                return NotFound();

            _context.DescricoesCranios.Remove(dados);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
