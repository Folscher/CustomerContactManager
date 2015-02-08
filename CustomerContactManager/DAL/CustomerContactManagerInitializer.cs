﻿using CustomerContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerContactManager.DAL
{
    public class CustomerContactManagerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CustomerContactManagerContext>
    {
        protected override void Seed(CustomerContactManagerContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{ Name= "Folscher", Latitude = "-33,53,45", Longitude = "18,35,29", DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new Customer{ Name= "Dewald", Latitude = "-33,53,45", Longitude = "18,35,29", DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new Customer{ Name= "Christoff", Latitude = "-33,53,45", Longitude = "18,35,29", DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new Customer{ Name= "Corne", Latitude = "-33,53,45", Longitude = "18,35,29", DateCreated = DateTime.Now, DateModified = DateTime.Now.Date}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var contacts = new List<CustomerContact>
            {
                new CustomerContact{CustomerID=1,Name="Simon",Email="Simon@gmail.com",ContactNumber = "1234567890",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=1,Name="Colin",Email="Colin@gmail.com",ContactNumber = "0987654321",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=1,Name="Pete",Email="Pete@gmail.com",ContactNumber = "6547893210",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=1,Name="Desmon",Email="Desmon@gmail.com",ContactNumber = "3214569870",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                                                       
                new CustomerContact{CustomerID=2,Name="Simon",Email="Simon@gmail.com",ContactNumber = "1234567890",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=2,Name="Colin",Email="Colin@gmail.com",ContactNumber = "0987654321",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=2,Name="Pete",Email="Pete@gmail.com",ContactNumber = "6547893210",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                                                       
                new CustomerContact{CustomerID=3,Name="Simon",Email="Simon@gmail.com",ContactNumber = "1234567890",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=3,Name="Colin",Email="Colin@gmail.com",ContactNumber = "0987654321",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=3,Name="Pete",Email="Pete@gmail.com",ContactNumber = "6547893210",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=3,Name="Desmon",Email="Desmon@gmail.com",ContactNumber = "3214569870",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=3,Name="Frik",Email="Frik@gmail.com",ContactNumber = "1237890654",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                                                       
                new CustomerContact{CustomerID=4,Name="Simon",Email="Simon@gmail.com",ContactNumber = "1234567890",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=4,Name="Colin",Email="Colin@gmail.com",ContactNumber = "0987654321",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=4,Name="Pete",Email="Pete@gmail.com",ContactNumber = "6547893210",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=4,Name="Desmon",Email="Desmon@gmail.com",ContactNumber = "3214569870",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=4,Name="Frik",Email="Frik@gmail.com",ContactNumber = "1237890654",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},
                new CustomerContact{CustomerID=4,Name="Edd",Email="Edd@gmail.com",ContactNumber = "9871236540",DateCreated = DateTime.Now, DateModified = DateTime.Now.Date},

            };

            contacts.ForEach(s => context.CustomerContacts.Add(s));
            context.SaveChanges();
        }
    }
}
    
