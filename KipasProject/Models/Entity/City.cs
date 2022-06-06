using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KipasProject.Models.Entity
{
    public class City
    {
       
        public int ID { get; set; }
        
        public int CityID { get; set; }
        
        [StringLength(15)]
        public string Name { get; set; }
      

    }
}