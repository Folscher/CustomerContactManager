using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerContactManager.DAL;
using CustomerContactManager.Models;

namespace CustomerContactManager.Controllers
{
    public class CustomerContactAPIController : ApiController
    {
        // GET: api/CustomerContact
        public List<CustomerContact> Get()
        {
            CustomerContactManagerContext cx = new CustomerContactManagerContext();

            var customerContacts = cx.CustomerContacts;
            List<CustomerContact> contacts = customerContacts.ToList();
            


            return contacts;
        }

        // GET: api/CustomerContact/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CustomerContact
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CustomerContact/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CustomerContact/5
        public void Delete(int id)
        {
        }
    }
}
