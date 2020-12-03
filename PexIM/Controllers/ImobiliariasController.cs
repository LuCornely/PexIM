using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PexIM.Models;

namespace PexIM.Controllers
{
    public class ImobiliariasController : Controller
    {
        private readonly PexIMContext _context;

        public ImobiliariasController(PexIMContext context)
        {
            _context = context;
        }

        // GET: Imobiliarias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Imobiliarias.ToListAsync());
        }

        // GET: Imobiliarias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imobiliarias = await _context.Imobiliarias
                .FirstOrDefaultAsync(m => m.CodImobiliaria == id);
            if (imobiliarias == null)
            {
                return NotFound();
            }

            return View(imobiliarias);
        }

        // GET: Imobiliarias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Imobiliarias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodImobiliaria,Nome,Excluido,CodImobiliariaApi")] Imobiliarias imobiliarias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imobiliarias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imobiliarias);
        }

        // GET: Imobiliarias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imobiliarias = await _context.Imobiliarias.FindAsync(id);
            if (imobiliarias == null)
            {
                return NotFound();
            }
            return View(imobiliarias);
        }

        // POST: Imobiliarias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodImobiliaria,Nome,Excluido,CodImobiliariaApi")] Imobiliarias imobiliarias)
        {
            if (id != imobiliarias.CodImobiliaria)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imobiliarias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImobiliariasExists(imobiliarias.CodImobiliaria))
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
            return View(imobiliarias);
        }

        // GET: Imobiliarias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imobiliarias = await _context.Imobiliarias
                .FirstOrDefaultAsync(m => m.CodImobiliaria == id);
            if (imobiliarias == null)
            {
                return NotFound();
            }

            return View(imobiliarias);
        }

        // POST: Imobiliarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imobiliarias = await _context.Imobiliarias.FindAsync(id);
            _context.Imobiliarias.Remove(imobiliarias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImobiliariasExists(int id)
        {
            return _context.Imobiliarias.Any(e => e.CodImobiliaria == id);
        }
    }
}
