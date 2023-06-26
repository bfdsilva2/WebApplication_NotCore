using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_NotCore.Models
{
    public class PersonModel
    {
        public int IdPerson { get; set; }

        [Editable(false)]
        public string Name { get; set; }

        public string Fullname { get; set; }

        //[Required]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime BirthDate { get; set; }        

    }
}