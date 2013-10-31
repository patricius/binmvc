using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace binarymvc.Models
{

    public class binarymodelinput
    {
    [Required(ErrorMessage = "Please enter an integer")]
    [DisplayName("Int to convert")]
        public int Input { get; set; }
       
       
    }
}