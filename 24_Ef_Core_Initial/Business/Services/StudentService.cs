using Ef_Core_Initial.Business.Interfaces;
using Ef_Core_Initial.Data;
using Ef_Core_Initial.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Business.Services
{
    internal class StudentService : IStudentService
    {
        
        //Abstract -> Concrete

        public void AddStudent(Student student)
        {
            Context context = new Context();

       
            context.Students.Add(student);
 
            context.SaveChanges();

        }

        public bool DeleteStudent(int id)
        {
            Context context = new Context();

            var result = context.Students.FirstOrDefault(s => s.StudentId == id);
            
            if(result != null)
            {

                context.Students.Remove(result);
                context.SaveChanges();

                return true;
            }
            else
            {
                return false;

            }

        }

        public List<Student> GetAllStudents()
        {
            Context context = new Context();

            return context.Students.ToList();
        }

        public void UpdateStudent(Student student)
        {
            Context context = new Context();

            var id = student.StudentId;

            var result = context.Students.FirstOrDefault(s => s.StudentId == id);

            if (result != null) {
            
                result.Surname = student.Surname;
                result.Name = student.Name;
                result.UpdateDate = DateTime.Now;
                context.Students.Update(result);
                context.SaveChanges() ;
            }

        }


    }
}
