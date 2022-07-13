using BankProj.BankApplication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProj.Controllers
{
    public class TransactionDetailController : Controller
    {
        private readonly AssignmentDBContext _context;
       
        public TransactionDetailController(AssignmentDBContext context)
        {
            _context = context;
        }
        public IActionResult Transdetail(int credit,string name,int debit,string toname)
        {
            long? balance, transamt;
            string madeby, madeto, transtype, date, status;
            UserAccountDetail us = new UserAccountDetail();
            BankInformation b = new BankInformation();
            us= _context.UserAccountDetails.FirstOrDefault(m =>m.FullName==name);
            b=_context.BankInformations.FirstOrDefault(n => n.AccountNumber == us.AccountNumber);
            DateTime dt = DateTime.UtcNow;
            if(credit>0)
            {
                balance = b.Balance + credit;
                b.Balance = balance;
                madeto = "****";
                transamt = credit;
                transtype = "Credit";
            }
            else if(debit>0)
            {
                balance = b.Balance - debit;
                b.Balance = balance;
                madeto = toname;
                transamt = debit;
                transtype = "Debit";
            }
            else
            {
                return NotFound();
            }
            madeby = name;
            date = dt.ToShortDateString();
            status = "Success";
            TransactionDetail _transdetail = new(madeby, madeto, transamt, transtype, date, status, balance);
            _context.TransactionDetails.Add(_transdetail);
            _context.SaveChanges();
            _context.BankInformations.Update(b).Property(x => x.BankInfoId).IsModified = false; 
            _context.SaveChanges();
            return RedirectToAction("Def","Home");
        }
        public IActionResult passbook()
        {
            string gmail = HttpContext.User.Identity.Name;
            UserAccountDetail us = new UserAccountDetail();
            TransactionDetail b = new TransactionDetail();
            us = _context.UserAccountDetails.FirstOrDefault(m => m.Email == gmail);
            b = _context.TransactionDetails.FirstOrDefault(n => n.MadeBy == us.FullName);
            ViewBag.name = b.MadeBy;
            return View(_context.TransactionDetails.ToList());
        }
        public IActionResult Index()
        {
            TransactionDetail b = new TransactionDetail();
            return View(b);
            
        }
        [HttpPost]
        public IActionResult Index(int id)
        {
            TransactionDetail b = new TransactionDetail();
            b = _context.TransactionDetails.Find(id);
            return View(b);
        }
       
    }
}
