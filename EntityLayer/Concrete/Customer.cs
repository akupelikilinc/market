using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerGender { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerBirthDay { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerZipCode { get; set;}
        public string CustomerCity { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerIsActive { get; set; }


    }
}
