using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Dtos
{
    public class StudentDto
    {
        public int UniversityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CNP { get; set; }
        public List<int> CoursesIds { get; set; }
    }
}
