using Ef_Core_Initial.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Extensions
{
    public static class SeedDataCreator
    {

        public static void SeedDataCreate(this ModelBuilder modelBuilder)
        {
            #region ClubAdded
            modelBuilder.Entity<Club>().HasData(
                new Club
                {
                    ClubId = 1,
                    ClubName = "Yazılım",
                    ClubDescription = "Yazılım çok keyifli",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,

                },
                 new Club
                 {
                     ClubId = 2,
                     ClubName = "Kitap",
                     ClubDescription = "Kitap okumak çok keyifli",
                     CreateDate = DateTime.Now,
                     UpdateDate = DateTime.Now,

                 }
                );
            #endregion

            #region Field
            modelBuilder.Entity<Field>().HasData(
              new Field
              {
                  Id = 1,
                  Name = "Sayısal",
              },
               new Field
               {
                   Id = 2,
                   Name = "Eşit Ağırlık",
               },
               new Field
               {
                   Id = 3,
                   Name = "Sözel",
               }
              );
            #endregion

            #region Student
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    Name = "Tarık",
                    Surname = "Hamarat",
                    Birthdate = DateTime.Now,
                    CreateDate = DateTime.Now,
                    FieldId = 1


                },
                new Student
                {
                    StudentId = 2,
                    Name = "Ömer",
                    Surname = "Şahin",
                    Birthdate = DateTime.Now,
                    CreateDate = DateTime.Now,
                    FieldId = 2
                },
                new Student
                {
                    StudentId = 3,
                    Name = "Yusuf",
                    Surname = "Ergin",
                    Birthdate = DateTime.Now,
                    CreateDate = DateTime.Now,
                    FieldId = 3
                },
                new Student
                {
                    StudentId = 4,
                    Name = "Duhan",
                    Surname = "Göksal",
                    Birthdate = DateTime.Now,
                    CreateDate = DateTime.Now,
                    FieldId = 1
                }
                );
            #endregion

            #region Lesson
            modelBuilder.Entity<Lesson>().HasData(
                new Lesson
                {
                    LessonId = 1,
                    LessonName = "Matematik",
                    LessonCreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    CreateDate = DateTime.Now,

                }
                );
            #endregion

            #region StudentLesson
            modelBuilder.Entity<StudentLesson>().HasData(
               new StudentLesson
               {
                   LessonId = 1,
                   StudentId = 1,
                   UpdateDate = DateTime.Now,
                   CreateDate = DateTime.Now,


               }
               );
            #endregion

            #region Identity
            modelBuilder.Entity<Identity>().HasData(
                new Identity
                {
                    IdentityId = 1,
                    CardNumber = Guid.NewGuid().ToString(),
                    StudentId = 1,

                },
                new Identity
                {
                    IdentityId = 2,
                    CardNumber = Guid.NewGuid().ToString(),
                    StudentId = 2,
                },
                new Identity
                {
                    IdentityId = 3,
                    CardNumber = Guid.NewGuid().ToString(),
                    StudentId = 3,
                }

                );
            #endregion


        }
    }
}
