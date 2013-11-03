using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using editor_example.Models;
using System.Diagnostics;

namespace editor_example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(ListsOfThings.GetExampleLists());
        }

        [HttpPost]
        public ActionResult CakeOrDeath(ListsOfThings model)
        {
            Debug.Assert(model != null);
            Debug.Assert(model.NewThings != null);
            Debug.Assert(model.OldThings != null);
            return View("Index", model);
        }
    }
}
