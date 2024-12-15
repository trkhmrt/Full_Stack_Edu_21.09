using Ef_Core_Initial.Business.Services;
using Ef_Core_Initial.Data;
using Ef_Core_Initial.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace Ef_Core_Initial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var optionsBuilder = new DbContextOptionsBuilder<Context>();

            Context context = new Context();


            StudentService studentService = new StudentService();


            //Student student = new Student
            //{
            //    Name = "Tarık",
            //    Surname = "Hamarat",
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
            //    StudentId = 1,
            //    Name = "Tarık",
            //    Surname = "TESTTT",
            //};

            //studentService.UpdateStudent(student2);


            /*
             N tier architecture(N katmanlı mimarisi
             
             */



            //YENİ BİR ÖĞRENCİ KAYDI AL VE BU ÖĞRENCİYE SINIF TANIMLAMASI YAP

            //Student student = new Student
            //{
            //    Name = "Hakan",
            //    Surname = "er",
            //};



            //var founded_lesson = context.Lessons.FirstOrDefault(l => l.LessonId == 2);

            //StudentLesson studentLesson = new StudentLesson();


            //studentLesson.Student = student;
            //studentLesson.Lesson = founded_lesson;


            //context.StudentLessons.Add(studentLesson);
            //context.SaveChanges();


            //CLUB EKLEMEK VE CLUBE ÖĞRENCİ KAYDETMEK

            //Club club = new Club
            //{
            //    ClubName = "yazılım",
            //    ClubDescription = "biz burada tembelleri sevmeyiz."
            //};
            //context.Clubs.Add(club);



            //var founded_student = context.Students.FirstOrDefault(s => s.StudentId == 2);
            //founded_student.Clubs.Add(club);
            //context.SaveChanges();






        }
    }
}
