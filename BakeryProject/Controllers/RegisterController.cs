using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryProject.Models;

namespace Bakery.Project.Controllers
    {

    public class RegisterController : Controller
            {

        BakeryEntities db = new BakeryEntities();

        // GET: Register

        public ActionResult Register()

        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Register([Bind(Include = "PersonLastName, PersonFirstName, PersonEmail, PersonPhone, PersonPlainPassword")]NewPerson np)

        {
           Message msg = new Message();

            int result = db.usp_newPerson(np.PersonLastName, np.PersonFirstName, np.PersonEmail, np.PersonPhone, np.PersonPlainPassword);
            if (result != -1)

            {
                msg.MessageText = "Welcome, " + np.PersonFirstName;
             }
            else

            {
                msg.MessageText = "We found an error with your registration. Please try again.";

            }

            return View("Results", msg);
            }

        public ActionResult Results(Message msg)
         {
           return View(msg);

        }

    }

}