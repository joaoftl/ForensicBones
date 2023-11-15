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
    }
}