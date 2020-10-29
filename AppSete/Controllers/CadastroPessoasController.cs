using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppSete.Data;
using AppSete.Models;

namespace AppSete.Controllers
{
    public class CadastroPessoasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CadastroPessoasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CadastroPessoas
        public async Task<IActionResult> Index()
        {
            return View(await _context.CadastroPessoa.ToListAsync());
        }

        // GET: CadastroPessoas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroPessoa = await _context.CadastroPessoa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroPessoa == null)
            {
                return NotFound();
            }

            return View(cadastroPessoa);
        }

        // GET: CadastroPessoas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroPessoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,RegAtivo,DataRegistro")] CadastroPessoa cadastroPessoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroPessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroPessoa);
        }

        // GET: CadastroPessoas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroPessoa = await _context.CadastroPessoa.FindAsync(id);
            if (cadastroPessoa == null)
            {
                return NotFound();
            }
            return View(cadastroPessoa);
        }

        // POST: CadastroPessoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Nome,Cpf,RegAtivo,DataRegistro")] CadastroPessoa cadastroPessoa)
        {
            if (id != cadastroPessoa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroPessoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroPessoaExists(cadastroPessoa.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroPessoa);
        }

        // GET: CadastroPessoas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroPessoa = await _context.CadastroPessoa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroPessoa == null)
            {
                return NotFound();
            }

            return View(cadastroPessoa);
        }

        // POST: CadastroPessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cadastroPessoa = await _context.CadastroPessoa.FindAsync(id);
            _context.CadastroPessoa.Remove(cadastroPessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroPessoaExists(string id)
        {
            return _context.CadastroPessoa.Any(e => e.Id == id);
        }
    }
}
