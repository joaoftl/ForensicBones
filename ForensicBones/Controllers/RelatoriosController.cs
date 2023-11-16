using ForensicBones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForensicBones.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly AppDbContext _context; 
        public RelatoriosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Relatorios.ToListAsync();
            return View(dados);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Relatorio relatorio)
        {
            if (ModelState.IsValid)
            {
                _context.Relatorios.Add(relatorio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Relatorios.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }
    }
}
