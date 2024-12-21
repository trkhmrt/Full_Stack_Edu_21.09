using Ef_Core_Initial.Business.Interfaces;
using Ef_Core_Initial.Business.Services;
using Ef_Core_Initial.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial
{
    public class UI
    {
        IStudentService _studentService;

        public UI(IStudentService studentService)
        {

            _studentService = studentService;
           

        }


        public void OgrenciEkle()
        {
            //StudentService studentServiceClass = new StudentService();
            
            //studentServiceClass.AddStudent(new Student
            //{
               
            //    Name = "Tarık",
            //    Surname = "Hamarat",
            //    Birthdate = DateTime.Now,
            //    CreateDate = DateTime.Now,
            //    FieldId = 1


            //});

            //OgrenciServis ogrenciServis = new OgrenciServis();
            //ogrenciServis.AddStudent(new Student());



            _studentService.AddStudent(new Student
            {
               
                Name = "Tarık",
                Surname = "Hamarat",
                Birthdate = DateTime.Now,
                CreateDate = DateTime.Now,
                FieldId = 1


            });
           





        }

    }
}
