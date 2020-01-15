using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Step340.Models;
using Step340.ViewModels;

namespace Step340.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                                    int carYear, string carMake, string carModel, string dui, int speedingTickets, string fullCoverage, string liability)
        {
            using (Step340DBEntities db = new Step340DBEntities())
            {
                var quoteInfo = new QuoteInfo();
                quoteInfo.FirstName = firstName;
                quoteInfo.LastName = lastName;
                quoteInfo.EmailAddress = emailAddress;
                quoteInfo.DateOfBirth = dateOfBirth;
                quoteInfo.CarYear = carYear;
                quoteInfo.CarMake = carMake.ToLower();
                quoteInfo.CarModel = carModel.ToLower();
                quoteInfo.Dui = dui.ToLower();
                quoteInfo.SpeedingTickets = speedingTickets;
                quoteInfo.FullCoverage = fullCoverage.ToLower();
                quoteInfo.Liability = liability.ToLower();


                double quote = 50.0;
                DateTime today = DateTime.Now;
                int currentYear = today.Year;
                int age =  currentYear - dateOfBirth.Year;
                if (age < 25)
                {
                    quote = quote + 25;
                }
                if (age < 18)
                {
                    quote = quote + 100;
                }
                if (age > 100)
                {
                    quote = quote + 25;
                }
                if (quoteInfo.CarYear < 2000 || quoteInfo.CarYear > 2015)
                {
                    quote = quote + 25;
                }
                if (quoteInfo.CarMake == "porsche")
                {
                    quote = quote + 25;
                }
                if (quoteInfo.CarMake == "porsche" && quoteInfo.CarModel == "911 Carrera")
                {
                    quote = quote + 25;
                }
                if (quoteInfo.SpeedingTickets > 0)
                {
                    quote = Convert.ToInt32(quote + (10 * quoteInfo.SpeedingTickets));
                    quote = Convert.ToDouble(quote);
                }
                if (quoteInfo.Dui == "y")
                {
                    quote = quote + (quote * 0.25);
                }
                if (quoteInfo.FullCoverage == "y")
                {
                    quote = quote + (quote * 0.5);
                }
                quoteInfo.Quote = quote;



                db.QuoteInfoes.Add(quoteInfo);
                db.SaveChanges();
            }            

            return View("Success");
        }
    }
}