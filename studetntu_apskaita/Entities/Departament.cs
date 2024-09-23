using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studetntu_apskaita.Entities
{
    public class Departament
    {
        public string DepartmentId { get; set; } //cs12356 
        public string DepartamentName { get; set; }
        public ICollection<Lecture> Lecture { get; set; } = new List<Lecture>();    

    }
}
 