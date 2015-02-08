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
        public List<CustomerContact> GetCustomerContact()
        {
            CustomerContactManagerContext cx = new CustomerContactManagerContext();

            var customerContacts = cx.CustomerContacts;
            List<CustomerContact> contacts = customerContacts.ToList();
            
            return contacts;
        }

        // GET: api/CustomerContact/5
        public CustomerContact GetCustomerContact(int id)
        {
            CustomerContactManagerContext cx = new CustomerContactManagerContext();

            var customerContacts = cx.CustomerContacts;
            var contact = (from v in customerContacts
                            where v.ID == id
                            select v).FirstOrDefault();

            if(contact == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return contact;
            
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
