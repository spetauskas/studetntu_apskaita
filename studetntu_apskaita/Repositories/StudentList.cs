using Microsoft.EntityFrameworkCore.Metadata.Internal;
using studetntu_apskaita.Entities;
using studetntu_apskaita.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static studetntu_apskaita.Repositories.StudentList;

namespace studetntu_apskaita.Repositories
{
    internal class StudentList: IStudentList
    {
        private readonly List<Student> _studentsList;

        //public StudentRepository(List<Student> students)
        //{
        //    _studentsList = students;
        //}
        public List<Student> GetAll()
        {
            return _studentsList;
        }

    }
}
