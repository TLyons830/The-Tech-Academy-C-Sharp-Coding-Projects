using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Step340.Models;
using Step340.ViewModels;

namespace Step340.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (Step340DBEntities db = new Step340DBEntities())
            {
                var quotes = db.QuoteInfoes.ToList();
                List<AdminVM> adminQuotes = new List<AdminVM>();
                foreach (var quote in quotes)
                {
                    var quoteVM = new AdminVM();
                    quoteVM.FirstName = quote.FirstName;
                    quoteVM.LastName = quote.LastName;
                    quoteVM.EmailAddress = quote.EmailAddress;
                    quoteVM.Quote = Convert.ToDouble(quote.Quote);

                    adminQuotes.Add(quoteVM);
                }
                return View(adminQuotes);
            }
            
        }
    }
}