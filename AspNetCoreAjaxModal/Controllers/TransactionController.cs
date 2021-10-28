using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetCoreAjaxModal.Models;
using AspNetCoreAjaxModal.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AspNetCoreAjaxModal.Controllers
{
    public class TransactionController : Controller
    {
        private readonly TransactionsDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public TransactionController(TransactionsDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
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
                var transactionModel = new TransactionModel();
                var transactionViewModel = new TransactionViewModel();
                transactionViewModel.TransactionModel = transactionModel;
                return View(transactionViewModel);
            }
            else
            {
                var transactionModel = await _context.Transactions.FindAsync(id);
                if (transactionModel == null)
                {
                    return NotFound();
                }
                ViewData["BankId"] = new SelectList(_context.Banks, "Id", "BankName", transactionModel.BankId);

                var transactionViewModel = new TransactionViewModel {
                    TransactionId = transactionModel.TransactionId,
                    AccountNumber = transactionModel.AccountNumber,
                    BeneficiaryName = transactionModel.BeneficiaryName,
                    BankId = transactionModel.BankId,
                    Amount = transactionModel.Amount,
                    SwiftCode = transactionModel.SwiftCode,
                    TransactionDateTime = transactionModel.TransactionDateTime,
                    TransactionModel = transactionModel
                };
                return View(transactionViewModel);
            }
        }

        // POST: Transaction/AddOrEdit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [
            Bind("TransactionId,AccountNumber,BeneficiaryName,BankId,SwiftCode,Amount,TransactionDateTime,Photo")
            ] TransactionViewModel transactionViewModel)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                if (transactionViewModel.Photo != null)
                {
                    string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + transactionViewModel.Photo.FileName;
                    string uploadPath = Path.Combine(uploadFolder, uniqueFileName);
                    //transactionViewModel.Photo.CopyTo(new FileStream(uploadPath, FileMode.Create));
                    FileStream fs = new FileStream(uploadPath, FileMode.Create);
                    transactionViewModel.Photo.CopyTo(fs);
                    fs.Close();
                }

                var transactionModel = new TransactionModel
                {
                    TransactionId = transactionViewModel.TransactionId,
                    AccountNumber = transactionViewModel.AccountNumber,
                    BeneficiaryName = transactionViewModel.BeneficiaryName,
                    BankId = transactionViewModel.BankId,
                    Amount = transactionViewModel.Amount,
                    SwiftCode = transactionViewModel.SwiftCode,
                    TransactionDateTime = transactionViewModel.TransactionDateTime,
                    PhotoPath = uniqueFileName
                };

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
            ViewData["BankId"] = new SelectList(_context.Banks, "Id", "BankName", transactionViewModel.TransactionModel.BankId);
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", transactionViewModel) });
        }

        // POST: Transaction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transactionModel = await _context.Transactions.FindAsync(id);

            string fileName = transactionModel.PhotoPath;
            if (fileName != null && fileName.Length > 0)
            {
                try
                {
                    string fileFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    string filePath = Path.Combine(fileFolder, fileName);
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
            _context.Transactions.Remove(transactionModel);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Transactions.Include(t => t.Bank).ToList()) });
        }

        // POST: Transaction/ShowSearchResults/"SomeTextPatternForSearch"
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            var transactionsDbSearchContext = await _context.Transactions.Include(t => t.Bank).Where(j => j.BeneficiaryName.Contains(SearchPhrase) || j.Bank.BankName.Contains(SearchPhrase)).ToListAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", transactionsDbSearchContext) });
        }

        private bool TransactionModelExists(int id)
        {
            return _context.Transactions.Any(e => e.TransactionId == id);
        }
    }
}
