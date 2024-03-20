using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class UserContoller : Controller
    {

        public Table_1 usrtbl= new Table_1();


        [HttpPost]
        public ActionResult About(Table_1 usrtbl)
        {
            var result = usrtbl.insert_User(usrtbl);
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]

        public ActionResult About()
        {
            return View(usrtbl);
        
      
        }
    }
}
