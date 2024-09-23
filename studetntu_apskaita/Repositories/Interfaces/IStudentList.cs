using Microsoft.EntityFrameworkCore.Metadata.Internal;
using studetntu_apskaita.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studetntu_apskaita.Repositories.Interfaces
{
    public interface IStudentList
    {
       // public void Getall();
        List<Student> GetAll();
    }
}
