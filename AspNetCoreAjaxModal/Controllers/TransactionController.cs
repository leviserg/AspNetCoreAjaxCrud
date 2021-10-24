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
    public class TransactionController : Controller
    {
        private readonly TransactionsDbContext _context;

        public TransactionController(TransactionsDbContext context)
        {
            _context = context;
        }

        // GET: Transaction
        public async Task<IActionResult> Index()
        {
            var transactionsDbContext = _context.Transactions.Include(t => t.Bank);
            return View(await transactionsDbContext.ToListAsync());
        }

        // GET: Transaction/AddOrEdit
        // GET: Transaction/AddOrEdit/{id:5}
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            /*
            var transactionModel = await _context.Transactions
                .Include(t => t.Bank)
                .FirstOrDefaultAsync(m => m.TransactionId == id);
            */
            if (id == 0)
            {
                ViewData["BankId"] = new SelectList(_context.Banks, "Id", "BankName",1);
                return View(new TransactionModel());
            }
            else
            {
                var transactionModel = await _context.Transactions.FindAsync(id);
                if (transactionModel == null)
                {
                    return NotFound();
                }
                ViewData["BankId"] = new SelectList(_context.Banks, "Id", "BankName", transactionModel.BankId);
                return View(transactionModel);
            }
        }

        // POST: Transaction/AddOrEdit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("TransactionId,AccountNumber,BeneficiaryName,BankId,SwiftCode,Amount,TransactionDateTime")] TransactionModel transactionModel)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    if (transactionModel.TransactionDateTime.ToString().Length == 0)
                    {
                        transactionModel.TransactionDateTime = DateTime.Now;
                    }
                    _context.Add(transactionModel);
                    await _context.SaveChangesAsync();
                }
                else {
                    try
                    {
                        _context.Update(transactionModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!TransactionModelExists(transactionModel.TransactionId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this,"_ViewAll",_context.Transactions.Include(t => t.Bank).ToList()) });
            }
            ViewData["BankId"] = new SelectList(_context.Banks, "Id", "BankName", transactionModel.BankId);
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", transactionModel) });
        }

        // POST: Transaction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transactionModel = await _context.Transactions.FindAsync(id);
            _context.Transactions.Remove(transactionModel);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Transactions.Include(t => t.Bank).ToList()) });
        }

        // POST: Transaction/AddOrEdit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            var transactionsDbSearchContext = await _context.Transactions.Include(t => t.Bank).Where(j => j.BeneficiaryName.Contains(SearchPhrase)).ToListAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", transactionsDbSearchContext) });
        }

        private bool TransactionModelExists(int id)
        {
            return _context.Transactions.Any(e => e.TransactionId == id);
        }
    }
}
