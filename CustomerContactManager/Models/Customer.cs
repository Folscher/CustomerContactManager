using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerContactManager.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<CustomerContact> CustomerContacts { get; set; }
    }
}