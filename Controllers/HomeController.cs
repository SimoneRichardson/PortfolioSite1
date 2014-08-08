using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //return a partial view if its an ajax request
            if (Request.IsAjaxRequest()) 
            {
                return PartialView();
            }
            //otherwise return a regular ole view

            return View();
        }
        
        //Get: /Home/About
        public ActionResult About()
        {
            //return a partial view if its an ajax request
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
         //otherwise return a regular ole view
            return View();
        }
        //Get: /Home/Work
        public ActionResult Work() 
        {
            //return a partial view if its an ajax request
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            //otherwise return a regular ole view  
            return View();
            }
    //Get: /Home/Contact
        [HttpGet]
        public ActionResult Contact() 
        {
            //return a partial view if its an ajax request
            if (Request.IsAjaxRequest()) 
            {
                return PartialView();
            }
            //otherwise return a regular ole view
            //create a new contact form object
            //pass to our view
            Models.ContactForm cf = new Models.ContactForm();
            return View(cf);
        }
        // POST: /Home/Contact
        [HttpPost]
        public ActionResult Contact(Models.ContactForm cf) 
        {
          //create a new connection to our database
            Models.ContactFormsEntities db = new Models.ContactFormsEntities();
            //add the contact infor to the database
            db.ContactForms.Add(cf);
            //save changes to the db
            db.SaveChanges();
        //redirect user to thank you page
            return RedirectToAction("ThankYou");
        }
        //Get: /Home/ThankYou
        public ActionResult ThankYou() 
        {
            return View();
        }
    }

}
