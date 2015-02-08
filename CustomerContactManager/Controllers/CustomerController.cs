using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerContactManager.DAL;
using CustomerContactManager.Models;
using System.Web.Http;
using System.Net;

namespace CustomerContactManager.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Customer()
        {
            return View();
        }

        public ActionResult CustomerCreate()
        {
            return View();
        }

        public ActionResult CustomerEdit()
        {
            return View();
        }

        public ActionResult CustomerDelete()
        {
            return View();
        }
    }
}