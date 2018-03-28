using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnePlace.Database.Entity;
namespace ProjectOnePlace.Controllers
{
    public class ReleaseController : Controller
    {
        // GET: ReleaseRequest
        public ActionResult NewRequest()
        {
            var db = new DBProjectOneplace();
            //db.SaveProject(new Project { Name="Test project", Comment="", DPMID="", ProdCDURL="", ProdPreviewURL="", Region="NA" , StageCDURL="" , StagePreviewURL=""});

            return View();
        }

        public ActionResult RequestList()
        {
            return View();
        }
    }

}