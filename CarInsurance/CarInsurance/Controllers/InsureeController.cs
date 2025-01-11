using CarInsurance.Models;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace CarInsurance.Models
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        //GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList<CarInsurance.Models.Insuree>());
        }

        //GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        //GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, SpeedingTickets, FullCoverage, Quote")] Insuree insuree)
        {
            if(ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }
            return View(insuree);
        }

        private decimal CalculateQuote(Insuree insuree)
        {
            //Base rate
            insuree.Quote = 50.0m;

            //Pricing based on age
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (DateTime.Now.Date < insuree.DateOfBirth.AddYears(age))
            {
                age--;
            }
            if (age <= 18)
            {
                insuree.Quote += 100m;
            }
            else if (age >= 19 && age <= 25)
            {
                insuree.Quote += 50m;
            }
            else if (age >= 26)
            {
                insuree.Quote += 25m;
            }

            //Pricing based on year of car
            if (insuree.CarYear < 2000)
            {
                insuree.Quote += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                insuree.Quote += 25;
            }

            //Pricing based on make and model of car
            if (insuree.CarMake.ToLower() == "porsche")
            {
                insuree.Quote += 25;

                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    insuree.Quote += 25;
                }
            }

            //Speeding tickets
            insuree.Quote += insuree.SpeedingTickets * 10;

            //DUI?
            if (insuree.DUI)
            {
                insuree.Quote *= 1.25m;
            }

            //Full coverage?
            if (insuree.CoverageType.ToString().ToLower() == "full")
            {
                return insuree.Quote;
            }
            insuree.Quote *= 1.50m;

            return insuree.Quote;
        }

        //GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        //POST: Insuree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID, FistName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, SpeedingTickets, Full Coverage, Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        //GET: Insure/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        //POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
