using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Dtos
{
    public class CourseDto
    {
        public string CourseName { get; set; }

        public int YearOfStudy { get; set; }

        public List<int> ProfessorsIds { get; set; }
        public List<int> StudentsIds { get; set; }

    }
}
