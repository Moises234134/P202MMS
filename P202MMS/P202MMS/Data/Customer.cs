using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P202MMS.Data
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public string Email { get; set; }

    }
}
