using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_NotCore.Models;

namespace WebApplication_NotCore.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                GetPersonById(id.Value);
            }

            ViewBag.Message = "Person page.";
            return View();
        }

        [HttpPost]
        public ActionResult Submit(PersonModel person)
        {
            if (IsFormChanged(person))
            {                
                ViewBag.ErrorMessage = "The form was changed.";
                return View(person);
            }

            if (ModelState.IsValid)
            {
                //saveData
                return RedirectToAction("Success");
            }
            
            return View(person);   
        }
       
        public ActionResult GetPersonById(int? idPerson)
        {
            //Code to get the person
            PersonModel person = new PersonModel() { IdPerson = 1, Name = "Bruno"};

            if (person == null)
                return RedirectToAction("Not Found");

            return View(person);
        }

        public JsonResult getPerson(string id)
        {
            List<PersonModel> listPerson = new List<PersonModel>()
            {
                new PersonModel() { IdPerson = 1, Name = "Bruno" },
                new PersonModel() { IdPerson = 2, Name = "Silva" }
            };
            
            return Json(listPerson, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Display()
        {
            List<PersonModel> listPerson = new List<PersonModel>()
            {
                new PersonModel() { IdPerson = 1, Name = "Bruno" },
                new PersonModel() { IdPerson = 2, Name = "Silva" }
            };

            return Json(listPerson, JsonRequestBehavior.AllowGet);
        }

        private bool IsFormChanged(PersonModel person)
        {
            return true;
        }
    }
}