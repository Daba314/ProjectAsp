using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class NewOrdClass
    {
        [Key]
        public int OrdID { get; set; }
        public String Item { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public String Material { get; set; }
    }
}