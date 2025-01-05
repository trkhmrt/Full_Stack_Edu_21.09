using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Data.Entities
{
    public class Student:BaseEntity
    {
        /// <summary>
        /// Burada Class adı Ve ıd ifadesi yanyana geldiği için [Key] şeklinde bir tanımlamaya gerek kalmıyor.
        /// </summary>
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }

        public List<Club> Clubs { get; set; } = new List<Club>();
        public List<StudentLesson> StudentLessons { get; set; }


        public int FieldId { get; set; }
        public Field Field { get; set; }

        public Identity Identity { get; set; }
    }
}
