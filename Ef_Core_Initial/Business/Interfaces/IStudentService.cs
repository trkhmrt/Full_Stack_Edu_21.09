using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef_Core_Initial.Data.Entities;

namespace Ef_Core_Initial.Business.Interfaces
{
    internal interface IStudentService
    {
        void AddStudent(Student student);

        void UpdateStudent(Student student);

        bool DeleteStudent(int id);

        List<Student> GetAllStudents();



    }
}
