using System;

namespace RihalDev.Models
{
    public class Students
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public int class_id { get; set; }
        public int country_id { get; set; }
      
        public Classes Classes { get; set; }

        public Countries Countries { get; set; }

    }
}
