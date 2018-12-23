using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public class Customer
    {
        
        public int Id{ get; set; }
        [Display(Name = "Họ và tên")]
        public string name { get; set; }
        [Display(Name = "Vị trí")]
        public string poisition { get; set; }
    }
}