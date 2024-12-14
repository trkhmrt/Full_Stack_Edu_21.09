using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Data.Entities
{
    public class Lesson:BaseEntity
    {

        [Key] //Aşağısındaki ifadenin Bu tabloda primary key olduğunu belirtiyoruz.
        public int LessonId { get; set; }

        public string LessonName { get; set; }

        public DateTime? LessonCreateDate { get; set; }

        public List<StudentLesson> StudentLessons { get; set; }



    }
}
