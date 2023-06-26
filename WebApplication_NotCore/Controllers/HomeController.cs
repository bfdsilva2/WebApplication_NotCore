using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_NotCore.Models;

namespace WebApplication_NotCore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page......";

            return View();
        }

       
        public ActionResult Ytech(string fullname = "")
        {
            ViewBag.Message = $"YTech page. Your fullname is {fullname}";

            return View();
        }

        public ActionResult HTMLHelpers()
        {
            ViewBag.Message = "HTMLHelpers Examples";

            return View();
        }

        public ActionResult JQueryExample()
        {
            ViewBag.Message = "Example";

            return View();
        }

        public ActionResult UpdateSection()
        {
            // Perform some logic to update the section content
            var updatedContent = "This is the updated content.";
            return PartialView("_SectionPartial", updatedContent);
        }

        [HttpGet]
        public ActionResult GetInfo(int id, string fullname)
        {
            PersonModel personModel = new PersonModel()
            {
                IdPerson = id,
                Fullname = fullname
            };
            return RedirectToAction("Index", "Person", personModel);   
        }
    }
}