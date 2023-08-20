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
    public class BankAuthorizationFormController : Controller
    {
        private Bank_Management_SystemEntities2 db = new Bank_Management_SystemEntities2();

        // GET: BankAuthorizationForms
        public ActionResult Index()
        {
            return View(db.BankAuthorizationForms.ToList());
        }

        // GET: BankAuthorizationForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankAuthorizationForm bankAuthorizationForm = db.BankAuthorizationForms.Find(id);
            if (bankAuthorizationForm == null)
            {
                return HttpNotFound();
            }
            return View(bankAuthorizationForm);
        }

        // GET: BankAuthorizationForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankAuthorizationForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,City,Firstname,Lastname,EmailId,Phone_No,BankName,BankBranch,BankPhonenumber,Type_OF_BankAccount")] BankAuthorizationForm bankAuthorizationForm)
        {
            if (ModelState.IsValid)
            {
                db.BankAuthorizationForms.Add(bankAuthorizationForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bankAuthorizationForm);
        }

        // GET: BankAuthorizationForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankAuthorizationForm bankAuthorizationForm = db.BankAuthorizationForms.Find(id);
            if (bankAuthorizationForm == null)
            {
                return HttpNotFound();
            }
            return View(bankAuthorizationForm);
        }

        // POST: BankAuthorizationForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,City,Firstname,Lastname,EmailId,Phone_No,BankName,BankBranch,BankPhonenumber,Type_OF_BankAccount")] BankAuthorizationForm bankAuthorizationForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bankAuthorizationForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bankAuthorizationForm);
        }

        // GET: BankAuthorizationForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankAuthorizationForm bankAuthorizationForm = db.BankAuthorizationForms.Find(id);
            if (bankAuthorizationForm == null)
            {
                return HttpNotFound();
            }
            return View(bankAuthorizationForm);
        }

        // POST: BankAuthorizationForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BankAuthorizationForm bankAuthorizationForm = db.BankAuthorizationForms.Find(id);
            db.BankAuthorizationForms.Remove(bankAuthorizationForm);
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
