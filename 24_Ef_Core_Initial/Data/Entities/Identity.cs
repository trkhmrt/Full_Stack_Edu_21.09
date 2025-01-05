using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Data.Entities
{
    public  class Identity:BaseEntity
    {
        //-- ID -> 120    StudentID -> 200  
        public int IdentityId { get; set; }

        public string CardNumber { get; set; }


        public int StudentId { get; set; }

        public Student Student { get; set; }









    }
}
