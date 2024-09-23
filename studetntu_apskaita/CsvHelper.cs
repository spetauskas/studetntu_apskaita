using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studetntu_apskaita.Entities;

namespace studetntu_apskaita
{
    internal class CsvHelper
    {
        public static List<Departament> GetDepartament()
        {
            var csv = File.ReadAllLines("InitialData\\departaments.csv");
            var departaments = new List<Departament>();
            foreach (var line in csv)
            {
                var values = line.Split(',');
                var departament = new Departament
                {
                    DepartamentID = int.Parse(values[0]),
                    DepartamentName = values[1]
                
                };
                departaments.Add(departament);
            }
            return departaments;
        }
        public static List<Lecture> GetLessons() 
        {

            var csv = File.ReadAllLines("InitialData\\lectures.csv");
            var lessons = new List<Lecture>();
            foreach (var line in csv)
            {
                var values = line.Split(",");
                var lesson = new Lecture
                {
                    LectureId = int.Parse(values[0]),
                    LectureName = values[1]
                };
                lessons.Add(lesson);
            }
            return lessons;
        }
        public static List<Student> GetStudents()
        {
            var csv = File.ReadAllLines("InitialData\\students.csv");
            var students = new List<Student>(); 
            foreach (var line in csv)
            {
                var values = line.Split(",");
                var student = new Student
                {
                    FirstName = values[0],
                    LastName = values[1],
                    StudentId = int.Parse(values[2]),
                    Email = values[3]
                    // ar reikia isirasyti icollection<departament> navigacini propertie?
                };
                students.Add(student);
            }
            return students;

        }



    }

}
