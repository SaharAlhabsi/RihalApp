using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalDev.Models
{
    public class Countries
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string name { get; set; }
        public List<Students> Students { get; set; }
        public int count { get; set; }

    }
}
