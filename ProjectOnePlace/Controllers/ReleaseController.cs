using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOnePlace.Controllers
{
    public class ReleaseController : Controller
    {
        // GET: ReleaseRequest
        public ActionResult NewRequest()
        {
            return View();
        }

        public ActionResult RequestList()
        {
            return View();
        }
    }
}