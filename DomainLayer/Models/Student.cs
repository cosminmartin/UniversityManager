
namespace DomainLayer.Models
{
    public class Student
    {
        public int UniversityId { get; set; }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CNP { get; set; }

        public long Medie { get; set; }
        public virtual University University { get; set; }  // (Convention 1 when single, Convention 3 when along with ICollection<Student>) One-To-Many https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx

        

        public Student(string firstName, string lastName, long cNP, long medie, int universityId)  
        { 
            FirstName = firstName;
            LastName = lastName;
            CNP = cNP;
            Medie = medie;
            UniversityId = universityId;
        }

        public Student()  // ca asa vrea Entity
        {
        }

        public virtual ICollection<Course> Courses { get; set; }     
    }
}
