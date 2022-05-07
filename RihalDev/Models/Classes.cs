using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalDev.Models
{
    public class Classes
    {

        public int Id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Students> Students { get; set; }


    }
}
