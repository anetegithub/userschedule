using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserSchedule.Controllers
{
    public class UserManagmentController : Controller
    {
        [HttpGet]
        public ActionResult Read()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete()
        {
            return View();
        }
    }
}