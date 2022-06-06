
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KipasProject.Models.Entity
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "First Name")]
        [StringLength(10, ErrorMessage = "First Name length can't be more than 10.")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]

        [StringLength(20, ErrorMessage = "Last Name length can't be more than 20.")]
        public string LastName { get; set; }

        [Display(Name ="Title")]
        [StringLength(30, ErrorMessage = "Title length can't be more than 30.")]
        public string Prefix { get; set; }
        [Display(Name = "Position")]
       
        public string Position { get; set; }
        
        [Display(Name = "Birth Date")]
        
        public DateTime? BirthDate { get; set; }
        [Display(Name = "Hire Date")]
      
        public DateTime? HireDate { get; set; }
        [Display(Name = "Notes")]
        
        public string Notes { get; set; }
        [Display(Name = "Address ")]
       
        public string Address { get; set; }
        [Display(Name = "State ")]
        
        public int CityID { get; set; }
     

    }
}