
namespace DomainLayer.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public int YearOfStudy { get; set; }
        public Course(string courseName)
        {        
            CourseName = courseName;         
        }
        public Course()
        {
        }
        public virtual ICollection<Student> Students { get; set; } 
        public virtual ICollection<Professor> Professors { get; set; }
    }
}
