using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Data.Entities
{
    public class Club:BaseEntity
    {
        public int ClubId { get; set; }

        public string ClubName { get; set; }

        public string ClubDescription { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
             




    }
}
