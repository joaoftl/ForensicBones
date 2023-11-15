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
    }
}
