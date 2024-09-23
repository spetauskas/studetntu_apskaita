using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studetntu_apskaita.Entities;
using System.IO;

namespace studetntu_apskaita
{
    internal class CsvHelper
    {
        public static List<Departament> GetDepartament()
        {
            var csv = File.ReadAllLines("C:\\Users\\spoka\\source\\repos\\studetntu_apskaita\\studetntu_apskaita\\InitialData\\departamentLectures.csv");
            var departaments = new List<Departament>();
            foreach (var line in csv)
            {
                var values = line.Split(',');
                var departament = new Departament
                {
                    DepartmentId = values[0],
                    DepartamentName = values[1]
                
                };
                departaments.Add(departament);
            }
            return departaments;
        }
        public static List<Lecture> GetLecture() 
        {

            var csv = File.ReadAllLines("C:\\Users\\spoka\\source\\repos\\studetntu_apskaita\\studetntu_apskaita\\InitialData\\lectures.csv");
            var lessons = new List<Lecture>();
            foreach (var line in csv)
            {
                var values = line.Split(",");
                // Trim whitespace and split the time range (e.g., "14:00-15:30")
                var timeRange = values[1].Trim().Split("-");
                var lesson = new Lecture
                {
                    LectureName = values[0].Trim(),
                  
                    LectureTime = DateTime.ParseExact(timeRange[0].Trim(), "HH:mm", null)
                };
                lessons.Add(lesson);
            }
            return lessons;
        }
        public static List<Student> GetStudents()
        {
            var csv = File.ReadAllLines("C:\\Users\\spoka\\source\\repos\\studetntu_apskaita\\studetntu_apskaita\\InitialData\\students.csv");
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
