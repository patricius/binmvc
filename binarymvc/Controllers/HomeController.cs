using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using binarymvc.Models;

namespace binarymvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

     
        //
        // GET: /Home/Details/5

        public ActionResult GetInput()
        {

            return View();
        }

        //
        // GET: /Home/Create


        [HttpPost]
        public ActionResult GetInput(int input)
        {
            if (ModelState.IsValid)
            {
                binaryoutput output = new binaryoutput(input);
                return View("Results", output);
            }
            else return View();
        }
    }
}
      