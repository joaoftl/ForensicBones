﻿using ForensicBones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForensicBones.Controllers
{
    public class InventariosController : Controller
    {
        private readonly AppDbContext _context;
        public InventariosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Inventarios.ToListAsync();
            return View(dados);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(InventarioEsqueleto inventarioesqueleto)
        {
            if (ModelState.IsValid)
            {
                _context.Inventarios.Add(inventarioesqueleto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Inventarios.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }
    }
}
