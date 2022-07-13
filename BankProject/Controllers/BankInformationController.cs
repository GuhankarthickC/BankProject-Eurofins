using BankProj.BankApplication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProj.Controllers
{
    public class BankInformationController : Controller
    {
        private readonly AssignmentDBContext _context;
  
        public BankInformationController(AssignmentDBContext context)
        {
            _context = context;
        }
      
        // GET: UserAccountDetails
        public async Task<IActionResult> Index()
        {
            string data = HttpContext.User.Identity.Name;
            if (data == null)
            {
                return NotFound();
            }

            var userAccountDetail = await _context.UserAccountDetails
                .FirstOrDefaultAsync(m => m.Email == data);
            if (userAccountDetail == null)
            {
                return NotFound();
            }
            var bankinfo = await _context.BankInformations.FirstOrDefaultAsync(n => n.AccountNumber == userAccountDetail.AccountNumber);
            return View(bankinfo);
        }
        [HttpPost]
        public IActionResult Index(int creditamount)
        {
            string data = HttpContext.User.Identity.Name;
            var userAccountDetail =  _context.UserAccountDetails
                .FirstOrDefault(m => m.Email == data);
            return RedirectToAction("Transdetail","TransactionDetail",new {credit=creditamount,name=userAccountDetail.FullName,debit=0,toname=""});
        }
        public IActionResult Debit(string accno, string bankname, string ifsc, string receivername, int debitamount)
        {
            string data = HttpContext.User.Identity.Name;
            var userAccountDetail = _context.UserAccountDetails
                .FirstOrDefault(m => m.Email == data);
            return RedirectToAction("Transdetail", "TransactionDetail", new {credit = 0, name = userAccountDetail.FullName, debit = debitamount, toname = receivername });
        }
        
    }
}
