
namespace DomainLayer.Models
{
    public class University
    {
        public int UniversityId { get; set; }
        public string UniversityName { get; set; }

        public University(string universityName)
        {
           
            UniversityName = universityName;
        }

        public University()
        {      
        }

        public virtual ICollection<Student> Students { get; set; } //// (Convention 2 when single, Convention 3 when along with public University University) One-To-Many https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
        public virtual ICollection<Professor> Professors { get; set; }
    }
}
