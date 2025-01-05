using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Data.Entities
{
    public  class Field
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();



    }
}
