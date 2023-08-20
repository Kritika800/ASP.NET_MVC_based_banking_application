using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bank_Management_System.Models;

namespace Bank_Management_System.Controllers
{
    public class Bank_RatingController : Controller
    {
        private Bank_Management_SystemEntities2 db = new Bank_Management_SystemEntities2();

        // GET: Bank_Rating
        public ActionResult Index()
        {
            return View(db.Bank_Ratings.ToList());
        }

        // GET: Bank_Rating/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank_Rating bank_Rating = db.Bank_Ratings.Find(id);
            if (bank_Rating == null)
            {
                return HttpNotFound();
            }
            return View(bank_Rating);
        }

        // GET: Bank_Rating/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bank_Rating/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Company_Name,Financial_Institution_Name,Financial_Institution_Contact_Name,Name,Account_Type,Account_In_The_name_Of_FirstName,LastName,Balance,Signature")] Bank_Rating bank_Rating)
        {
            if (ModelState.IsValid)
            {
                db.Bank_Ratings.Add(bank_Rating);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bank_Rating);
        }

        // GET: Bank_Rating/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank_Rating bank_Rating = db.Bank_Ratings.Find(id);
            if (bank_Rating == null)
            {
                return HttpNotFound();
            }
            return View(bank_Rating);
        }

        // POST: Bank_Rating/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Company_Name,Financial_Institution_Name,Financial_Institution_Contact_Name,Name,Account_Type,Account_In_The_name_Of_FirstName,LastName,Balance,Signature")] Bank_Rating bank_Rating)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bank_Rating).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bank_Rating);
        }

        // GET: Bank_Rating/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank_Rating bank_Rating = db.Bank_Ratings.Find(id);
            if (bank_Rating == null)
            {
                return HttpNotFound();
            }
            return View(bank_Rating);
        }

        // POST: Bank_Rating/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bank_Rating bank_Rating = db.Bank_Ratings.Find(id);
            db.Bank_Ratings.Remove(bank_Rating);
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
