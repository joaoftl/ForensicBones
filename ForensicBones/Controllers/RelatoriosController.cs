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
    }
}
