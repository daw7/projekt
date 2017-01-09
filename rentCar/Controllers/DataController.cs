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

        public ActionResult getLoginData(Login obj)
        {
            CarRentalEntities db = new CarRentalEntities();
            var user = db.Users.Where(x => x.login.Equals(obj.Username) && x.password.Equals(obj.Password)).FirstOrDefault();
            return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}


// GET: Data
//public ActionResult Index()
//{
//    return View();
//}

//public JsonResult UserLogin(LoginData d)
//{
//    using (CarRentalEntities dc = new CarRentalEntities)
//    {
//        var user =
//        return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using rentCar.Models;
//using System.Text;
//using System.Web.Security;

//namespace rentCar.Controllers
//{
//    public class DataController : Controller
//    {

//        // GET: /Login/  
//        public ActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public string Login(Login data)
//        {
//            bool isPasswordCorrect = false;
//            string userName = data.Username;
//            string Password = data.Password;
//            using (CarRentalEntities entity = new CarRentalEntities())
//            {
//                var user = entity.Users.Where(x => x.login.Equals(data.Username) && x.password.Equals(data.Password)).FirstOrDefault();
//                if (user != null)
//                {
//                    if (userName == user.login && Password == user.password)
//                    {
//                        Session["LoginID"] = user.tp_UserID;
//                        Session["Username"] = user.firstName + ' ' + user.secondName;
//                        return user.tp_UserID.ToString();
//                    }
//                    else
//                    {
//                        return "0";
//                    }
//                }
//                else
//                {
//                    return "-1";
//                }
//            }
//        }
//    }
//}