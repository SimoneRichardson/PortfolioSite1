using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioSite.Models;

namespace PortfolioSite.Controllers
{
    public class ContactFormController : Controller
    {
        private ContactFormsEntities db = new ContactFormsEntities();

        //
        // GET: /ContactForm/

        public ActionResult Index()
        {
            return View(db.ContactForms.ToList());
        }

        //
        // GET: /ContactForm/Details/5

        public ActionResult Details(int id = 0)
        {
            ContactForm contactform = db.ContactForms.Find(id);
            if (contactform == null)
            {
                return HttpNotFound();
            }
            return View(contactform);
        }

        //
        // GET: /ContactForm/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ContactForm/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactForm contactform)
        {
            if (ModelState.IsValid)
            {
                db.ContactForms.Add(contactform);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactform);
        }

        //
        // GET: /ContactForm/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ContactForm contactform = db.ContactForms.Find(id);
            if (contactform == null)
            {
                return HttpNotFound();
            }
            return View(contactform);
        }

        //
        // POST: /ContactForm/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContactForm contactform)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactform).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactform);
        }

        //
        // GET: /ContactForm/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ContactForm contactform = db.ContactForms.Find(id);
            if (contactform == null)
            {
                return HttpNotFound();
            }
            return View(contactform);
        }

        //
        // POST: /ContactForm/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactForm contactform = db.ContactForms.Find(id);
            db.ContactForms.Remove(contactform);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}