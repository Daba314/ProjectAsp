using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class NewCustClass
    {
        [Key]
        public int CustID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int OrdID { get; set; }
        public int AddrID { get; set; }

    }
}

