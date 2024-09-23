using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studetntu_apskaita.Entities
{
    internal class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }

        public string Email { get; set; }
        public ICollection<Departament> Departaments { get; set; }
    }
}
