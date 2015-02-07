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
    public class CustomerAPIController : ApiController
    {
        // GET: api/Customer
        public List<Customer> Get()
        {
            CustomerContactManagerContext cx = new CustomerContactManagerContext();
            var customers = cx.Customers;
            List<Customer> custs = customers.ToList();

            if(custs == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return custs;
        }

        // GET: api/Customer/5
        public Customer Get(int id)
        {
            CustomerContactManagerContext cx = new CustomerContactManagerContext();
            var customers = cx.Customers;
            Customer cust = customers.Where(x => x.ID == id).FirstOrDefault();

            if (cust == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            

            return cust;

        }

        // POST: api/Customer
        public void Post([FromBody]Customer customer)
        {
            CustomerContactManagerContext cx = new CustomerContactManagerContext();
            var customers = cx.Customers;
            Customer cust = customers.Where(x => x.ID == customer.ID).FirstOrDefault();

            if (cust != null)
            {
                cust.Latitude = customer.Latitude;
                cust.Longitude = customer.Longitude;
                cust.Name = customer.Name;
                cust.DateModified = DateTime.Now;
            }
            else
            {
                cx.Customers.Add(customer);
            }
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
            CustomerContactManagerContext cx = new CustomerContactManagerContext();
            Customer cust = cx.Customers.Find(id);

            if (cust.CustomerContacts.Count == 0)
            {
                cx.Customers.Remove(cust);
            }
            else
            {
                foreach (CustomerContact cont in cust.CustomerContacts)
                {
                    cx.CustomerContacts.Remove(cont);
                }
                cx.Customers.Remove(cust);
            }
            cx.SaveChanges();
        }
    }
}
