using Ef_Core_Initial.Business.Services;
using Ef_Core_Initial.Data;
using Ef_Core_Initial.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ef_Core_Initial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            var optionsBuilder = new DbContextOptionsBuilder<Context>();



            StudentService studentService = new StudentService();


            //Student student = new Student
            //{
            //    Name = "TarIk",
            //    Surname = "Hamarat",
            //    Birthdate = DateTime.Now,
            //};

            //Student student2 = new Student
            //{
            //    Name = "Ömer",
            //    Surname = "Şahin",
            //    Birthdate = DateTime.Now,
            //};


            //studentService.AddStudent(student);
            //studentService.AddStudent(student2);


            //Console.WriteLine("Silinecek id değerini giriniz");
            //int id = Convert.ToInt32(Console.ReadLine());

            //var result =  studentService.DeleteStudent(id);

            //if (result)
            //{
            //    Console.WriteLine("Öğrenci Başarılı bir şekilde silindi!");
            //}
            //else
            //{
            //    Console.WriteLine("Öğrenci Bulunamadı.");
            //}


            //LİSTELEME 

            //studentService.GetAllStudents().ForEach(student => {

            //Console.WriteLine(student.Name + student.Surname);

            //});


            //UPDATE


            //Student student2 = new Student
            //{
            //    StudentId = 3,
            //    Name = "Ömer",
            //    Surname = "Kartal",
            //    Birthdate = DateTime.Now,
            //};

            //studentService.UpdateStudent(student2);


            /*
             N tier architecture(N katmanlı mimarisi
             
             */



            //YENİ BİR ÖĞRENCİ KAYDI AL VE BU ÖĞRENCİYE SINIF TANIMLAMASI YAP

            Student student = new Student
            {
                Name = "Hakan",
                Surname = "er",
            };



            var founded_lesson = context.Lessons.FirstOrDefault(l => l.LessonId == 2);

            StudentLesson studentLesson = new StudentLesson();

           
            studentLesson.Student = student;
            studentLesson.Lesson = founded_lesson;
            

            context.StudentLessons.Add(studentLesson);
            context.SaveChanges();








        }
    }
}
