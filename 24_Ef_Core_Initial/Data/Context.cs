﻿using Ef_Core_Initial.Configuration;
using Ef_Core_Initial.Data.Entities;
using Ef_Core_Initial.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Data
{
    internal class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-IBV340F\\FULLSTACKDB;Database=initial_db;Trusted_Connection=True;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new StudentConfiguration());



            modelBuilder.Entity<StudentLesson>().HasKey(x => new { x.StudentId, x.LessonId });

            modelBuilder.Entity<StudentLesson>().HasOne(sl => sl.Student).WithMany(s => s.StudentLessons).HasForeignKey(sl => sl.StudentId);

            modelBuilder.Entity<StudentLesson>().HasOne(sl => sl.Lesson).WithMany(s => s.StudentLessons).HasForeignKey(sl => sl.LessonId);


            modelBuilder.Entity<Student>()
                .HasOne(s => s.Identity)
                .WithOne(identity => identity.Student)
                .HasForeignKey<Identity>(fk => fk.StudentId);



            modelBuilder.SeedDataCreate();


            base.OnModelCreating(modelBuilder);


        }


        public DbSet<Student> Students { get; set; }

        public DbSet<Identity> Identities { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<StudentLesson> StudentLessons { get; set; }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<Field> Fields { get; set; }





    }
}
