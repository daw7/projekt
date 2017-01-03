//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace rentCar.Controllers
//{
//    public class DataController : Controller
//    {
//        // GET: Data
//        //public ActionResult Index()
//        //{
//        //    return View();
//        //}

//        public JsonResult UserLogin(LoginData d)
//        {
//            using (CarRentalEntities dc = new CarRentalEntities)
//            {
//                var user =
//                return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
//            }
//        }
//    }
//}