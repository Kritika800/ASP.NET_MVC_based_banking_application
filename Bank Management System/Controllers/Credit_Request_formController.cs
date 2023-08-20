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
    public class Credit_Request_formController : Controller
    {
        private Bank_Management_SystemEntities2 db = new Bank_Management_SystemEntities2();

        // GET: Credit_Request_form
        public ActionResult Index()
        {
            return View(db.Credit_Request_forms.ToList());
        }

        // GET: Credit_Request_form/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Credit_Request_form credit_Request_form = db.Credit_Request_forms.Find(id);
            if (credit_Request_form == null)
            {
                return HttpNotFound();
            }
            return View(credit_Request_form);
        }

        // GET: Credit_Request_form/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Credit_Request_form/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Parent_Name,PermanentAddress_Line1,PermanentAddress_Line2,PermanentAddress_Line3,City,Region,PostalCode,Country,Contact_Number,First_Participant_Name,DateOfBirth,Activity,Class_Code,Start_Date,Amount_Paid,Reason_For_CreditRequest,Employee_Signature")] Credit_Request_form credit_Request_form)
        {
            if (ModelState.IsValid)
            {
                db.Credit_Request_forms.Add(credit_Request_form);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(credit_Request_form);
        }

        // GET: Credit_Request_form/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Credit_Request_form credit_Request_form = db.Credit_Request_forms.Find(id);
            if (credit_Request_form == null)
            {
                return HttpNotFound();
            }
            return View(credit_Request_form);
        }

        // POST: Credit_Request_form/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Parent_Name,PermanentAddress_Line1,PermanentAddress_Line2,PermanentAddress_Line3,City,Region,PostalCode,Country,Contact_Number,First_Participant_Name,DateOfBirth,Activity,Class_Code,Start_Date,Amount_Paid,Reason_For_CreditRequest,Employee_Signature")] Credit_Request_form credit_Request_form)
        {
            if (ModelState.IsValid)
            {
                db.Entry(credit_Request_form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(credit_Request_form);
        }

        // GET: Credit_Request_form/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Credit_Request_form credit_Request_form = db.Credit_Request_forms.Find(id);
            if (credit_Request_form == null)
            {
                return HttpNotFound();
            }
            return View(credit_Request_form);
        }

        // POST: Credit_Request_form/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Credit_Request_form credit_Request_form = db.Credit_Request_forms.Find(id);
            db.Credit_Request_forms.Remove(credit_Request_form);
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
