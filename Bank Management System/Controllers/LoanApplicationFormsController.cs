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
    public class LoanApplicationFormsController : Controller
    {
        private Bank_Management_SystemEntities2 db = new Bank_Management_SystemEntities2();

        // GET: LoanApplicationForms
        public ActionResult Index()
        {
            return View(db.LoanApplicationForms.ToList());
        }

        // GET: LoanApplicationForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanApplicationForm loanApplicationForm = db.LoanApplicationForms.Find(id);
            if (loanApplicationForm == null)
            {
                return HttpNotFound();
            }
            return View(loanApplicationForm);
        }

        // GET: LoanApplicationForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoanApplicationForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Desired_Loan_Amount,Annual_Income,Your_Name,BirthDate,Phone_Number,EmailAddress,Home_Address,Line_2,Line_3,City,Region,Postal_Code,Country,Job_Title,Employer_Name,Confirm_Reason_Of_LOAN")] LoanApplicationForm loanApplicationForm)
        {
            if (ModelState.IsValid)
            {
                db.LoanApplicationForms.Add(loanApplicationForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loanApplicationForm);
        }

        // GET: LoanApplicationForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanApplicationForm loanApplicationForm = db.LoanApplicationForms.Find(id);
            if (loanApplicationForm == null)
            {
                return HttpNotFound();
            }
            return View(loanApplicationForm);
        }

        // POST: LoanApplicationForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Desired_Loan_Amount,Annual_Income,Your_Name,BirthDate,Phone_Number,EmailAddress,Home_Address,Line_2,Line_3,City,Region,Postal_Code,Country,Job_Title,Employer_Name,Confirm_Reason_Of_LOAN")] LoanApplicationForm loanApplicationForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loanApplicationForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loanApplicationForm);
        }

        // GET: LoanApplicationForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanApplicationForm loanApplicationForm = db.LoanApplicationForms.Find(id);
            if (loanApplicationForm == null)
            {
                return HttpNotFound();
            }
            return View(loanApplicationForm);
        }

        // POST: LoanApplicationForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoanApplicationForm loanApplicationForm = db.LoanApplicationForms.Find(id);
            db.LoanApplicationForms.Remove(loanApplicationForm);
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
