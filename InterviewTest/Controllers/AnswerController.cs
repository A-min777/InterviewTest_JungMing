using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterviewTest.Controllers
{
    public class AnswerController : Controller
    {
        // GET: Answer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Solution_Vue()
        {
            return View();
        }

        public ActionResult Solution_Multiple()
        {
            return View();
        }
    }
}