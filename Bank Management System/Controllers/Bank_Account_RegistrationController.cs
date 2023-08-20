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
    public class Bank_Account_RegistrationController : Controller
    {
        private Bank_Management_SystemEntities2 db = new Bank_Management_SystemEntities2();

        // GET: Bank_Account_Registration
        public ActionResult Index()
        {
            return View(db.Bank_Account_Registration.ToList());
        }

        // GET: Bank_Account_Registration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank_Account_Registration bank_Account_Registration = db.Bank_Account_Registration.Find(id);
            if (bank_Account_Registration == null)
            {
                return HttpNotFound();
            }
            return View(bank_Account_Registration);
        }

        // GET: Bank_Account_Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bank_Account_Registration/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Confirm_Type_Of_Bank_ACCOUNT,Confrim_Type_Of_CURRENCY,First_Name,Last_Name,Contact_Number,Email_Address,Mailing_Home_Address,City,State,Postal_Code,Country")] Bank_Account_Registration bank_Account_Registration)
        {
            if (ModelState.IsValid)
            {
                db.Bank_Account_Registration.Add(bank_Account_Registration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bank_Account_Registration);
        }

        // GET: Bank_Account_Registration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank_Account_Registration bank_Account_Registration = db.Bank_Account_Registration.Find(id);
            if (bank_Account_Registration == null)
            {
                return HttpNotFound();
            }
            return View(bank_Account_Registration);
        }

        // POST: Bank_Account_Registration/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Confirm_Type_Of_Bank_ACCOUNT,Confrim_Type_Of_CURRENCY,First_Name,Last_Name,Contact_Number,Email_Address,Mailing_Home_Address,City,State,Postal_Code,Country")] Bank_Account_Registration bank_Account_Registration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bank_Account_Registration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bank_Account_Registration);
        }

        // GET: Bank_Account_Registration/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank_Account_Registration bank_Account_Registration = db.Bank_Account_Registration.Find(id);
            if (bank_Account_Registration == null)
            {
                return HttpNotFound();
            }
            return View(bank_Account_Registration);
        }

        // POST: Bank_Account_Registration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bank_Account_Registration bank_Account_Registration = db.Bank_Account_Registration.Find(id);
            db.Bank_Account_Registration.Remove(bank_Account_Registration);
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
