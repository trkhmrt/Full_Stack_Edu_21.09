using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Data.Entities
{
    public class StudentLesson:BaseEntity
    {
        
        public int StudentId { get; set; }
        public Student Student { get; set; }


        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }





    }
}
