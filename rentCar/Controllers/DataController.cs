using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rentCar.Models;

namespace rentCar.Controllers
{
    public class DataController : Controller
    {
        [HttpPost]
        public ActionResult getLoginData(Login obj)
        {
            CarRentalEntities db = new CarRentalEntities();
            var user = db.Users.FirstOrDefault(x => x.login.Equals(obj.Username) && x.password.Equals(obj.Password));
            return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}