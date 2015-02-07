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
        public ActionResult Customer(int id)
        {
            CustomerContactManagerContext cx = new CustomerContactManagerContext();
            var custs = cx.Customers;

            Customer c = (from v in custs
                          where v.ID == id
                          select v).FirstOrDefault();

            if (custs == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            return View(c);
        }

        public ActionResult CustomerCreate(int id)
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