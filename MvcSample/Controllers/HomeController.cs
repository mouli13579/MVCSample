using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSample.BussinessData;
using Newtonsoft.Json;
using MvcSample.Models;
namespace MvcSample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Submit()
        {         
            Data data = new Data();
            DataTable dt = data.GetData();
            ViewBag.Data = dt;
            return View("Index", dt);
        }

        public JsonResult GetData()
        {
            JsonResult result = new JsonResult();
            Data data = new Data();
            DataTable dt = data.GetData();
            result.Data = JsonConvert.SerializeObject(dt);
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }
    }
}
