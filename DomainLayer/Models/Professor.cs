
namespace DomainLayer.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int UniversityId { get; set; }

      
        public virtual University University { get; set; } // OneToMany


        public Professor(string firstName, string lastName, int universityId)
        {
            FirstName = firstName;
            LastName = lastName;
            UniversityId = universityId;    
        }

        public Professor()
        {

        }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
