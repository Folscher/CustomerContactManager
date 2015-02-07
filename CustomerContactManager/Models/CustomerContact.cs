using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerContactManager.Models
{
    public class CustomerContact
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual Customer Customer { get; set; }
    }
}