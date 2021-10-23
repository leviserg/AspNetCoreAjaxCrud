using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetCoreAjaxModal.Models;

namespace AspNetCoreAjaxModal.Controllers
{
    public class BankController : Controller
    {
        private readonly TransactionsDbContext _context;

        public BankController(TransactionsDbContext context)
        {
            _context = context;
        }

        // GET: Bank
        public async Task<IActionResult> Index()
        {
            return View(await _context.Banks.ToListAsync());
        }

        // GET: Bank/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bank/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BankName")] BankModel bankModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bankModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bankModel);
        }

        // GET: Bank/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankModel = await _context.Banks.FindAsync(id);
            if (bankModel == null)
            {
                return NotFound();
            }
            return View(bankModel);
        }

        // POST: Bank/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BankName")] BankModel bankModel)
        {
            if (id != bankModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bankModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankModelExists(bankModel.Id))
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
            return View(bankModel);
        }

        // GET: Bank/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankModel = await _context.Banks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankModel == null)
            {
                return NotFound();
            }

            return View(bankModel);
        }

        // POST: Bank/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bankModel = await _context.Banks.FindAsync(id);
            _context.Banks.Remove(bankModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankModelExists(int id)
        {
            return _context.Banks.Any(e => e.Id == id);
        }
    }
}
