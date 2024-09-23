using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studetntu_apskaita.Entities
{
    internal class Lecture
    {
        public int  LectureId { get; set; }// galbut nereikia
        public string LectureName { get; set; }
        public DateTime LectureTime { get; set; }
    }
}
