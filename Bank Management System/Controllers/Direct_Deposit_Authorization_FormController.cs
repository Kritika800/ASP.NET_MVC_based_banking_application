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
    public class Direct_Deposit_Authorization_FormController : Controller
    {
        private Bank_Management_SystemEntities2 db = new Bank_Management_SystemEntities2();

        // GET: Direct_Deposit_Authorization_Form
        public ActionResult Index()
        {
            return View(db.Direct_Deposit_Authorization_Form.ToList());
        }

        // GET: Direct_Deposit_Authorization_Form/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direct_Deposit_Authorization_Form direct_Deposit_Authorization_Form = db.Direct_Deposit_Authorization_Form.Find(id);
            if (direct_Deposit_Authorization_Form == null)
            {
                return HttpNotFound();
            }
            return View(direct_Deposit_Authorization_Form);
        }

        // GET: Direct_Deposit_Authorization_Form/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Direct_Deposit_Authorization_Form/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Company_Name,FirstName,LastName,AddressLine1,Address_Line2,Address_Line3,City,Region,PostalCode,Country,Name_Of_Bank,Amount_ToBeDeposited,Type_Of_Account,Employees_Signature")] Direct_Deposit_Authorization_Form direct_Deposit_Authorization_Form)
        {
            if (ModelState.IsValid)
            {
                db.Direct_Deposit_Authorization_Form.Add(direct_Deposit_Authorization_Form);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(direct_Deposit_Authorization_Form);
        }

        // GET: Direct_Deposit_Authorization_Form/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direct_Deposit_Authorization_Form direct_Deposit_Authorization_Form = db.Direct_Deposit_Authorization_Form.Find(id);
            if (direct_Deposit_Authorization_Form == null)
            {
                return HttpNotFound();
            }
            return View(direct_Deposit_Authorization_Form);
        }

        // POST: Direct_Deposit_Authorization_Form/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Company_Name,FirstName,LastName,AddressLine1,Address_Line2,Address_Line3,City,Region,PostalCode,Country,Name_Of_Bank,Amount_ToBeDeposited,Type_Of_Account,Employees_Signature")] Direct_Deposit_Authorization_Form direct_Deposit_Authorization_Form)
        {
            if (ModelState.IsValid)
            {
                db.Entry(direct_Deposit_Authorization_Form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(direct_Deposit_Authorization_Form);
        }

        // GET: Direct_Deposit_Authorization_Form/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direct_Deposit_Authorization_Form direct_Deposit_Authorization_Form = db.Direct_Deposit_Authorization_Form.Find(id);
            if (direct_Deposit_Authorization_Form == null)
            {
                return HttpNotFound();
            }
            return View(direct_Deposit_Authorization_Form);
        }

        // POST: Direct_Deposit_Authorization_Form/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Direct_Deposit_Authorization_Form direct_Deposit_Authorization_Form = db.Direct_Deposit_Authorization_Form.Find(id);
            db.Direct_Deposit_Authorization_Form.Remove(direct_Deposit_Authorization_Form);
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
