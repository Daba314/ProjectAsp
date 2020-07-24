using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class NewAddrClass
    {
        [Key]
        public int AddrID { get; set; }
        public String City { get; set; }
        public String StreetName { get; set; }
        public int StreetNumber { get; set; }
        public String Province { get; set; }


    }
}
