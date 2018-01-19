using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RollBar.Controllers
{
    public class CreateErrorController : Controller
    {
        // GET: CreateError
        public ActionResult Index()
        {
            return View("CreateAnError");
        }

        [HttpPost]
        public ActionResult GenerateError()
        {
            //Models.model ExcptionModel = new Models.model();
            System.Diagnostics.Debug.WriteLine("abc");
            List<string> list = null;
            string testString = null;

            throw new Exception("This is test exception");
            ///System.Diagnostics.Debug.WriteLine(list.Count());

        }
    }
}