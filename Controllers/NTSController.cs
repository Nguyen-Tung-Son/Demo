using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TungSon;

namespace TungSon.Controllers
{
    public class NTSController : Controller
    {
        private readonly NTSContext _context;

        public NTSController(NTSContext context)
        {
            _context = context;
        }

        // GET: NTS
        public async Task<IActionResult> Index()
        {
            return View(await _context.NTS.ToListAsync());
        }

        // GET: NTS/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTS = await _context.NTS
                .FirstOrDefaultAsync(m => m.NTSID == id);
            if (nTS == null)
            {
                return NotFound();
            }

            return View(nTS);
        }

        // GET: NTS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTSID,NTSname")] NTS nTS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTS);
        }

        // GET: NTS/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTS = await _context.NTS.FindAsync(id);
            if (nTS == null)
            {
                return NotFound();
            }
            return View(nTS);
        }

        // POST: NTS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTSID,NTSname")] NTS nTS)
        {
            if (id != nTS.NTSID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTSExists(nTS.NTSID))
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
            return View(nTS);
        }

        // GET: NTS/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTS = await _context.NTS
                .FirstOrDefaultAsync(m => m.NTSID == id);
            if (nTS == null)
            {
                return NotFound();
            }

            return View(nTS);
        }

        // POST: NTS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nTS = await _context.NTS.FindAsync(id);
            _context.NTS.Remove(nTS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTSExists(string id)
        {
            return _context.NTS.Any(e => e.NTSID == id);
        }
    }
}
