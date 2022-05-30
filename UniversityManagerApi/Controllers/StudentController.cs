using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.Dtos;
using AutoMapper;
using ServicesLayer.Services;
using RepositoryLayer.GenericRepository;

namespace UniversityManagerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<University> UniversityRepository;
        private readonly IGenericRepository<Course> CourseRepository;

        public IStudentService StudentService => _studentService;

        public StudentController(IStudentService studentService, IMapper mapper, IGenericRepository<University> universityRepository, IGenericRepository<Course> courseRepository)
        {
            _studentService = studentService;
            _mapper = mapper;
            UniversityRepository = universityRepository;
            CourseRepository = courseRepository;
        }


        [HttpGet("Get-all-students")]
        public ActionResult GetAllStudents()
        {
            var result = _studentService.GetAllStudents();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No students found!");
        }


        [HttpGet("Get-student-by:{id}")]
        public ActionResult GetStudentById(int id)
        {
            var result = _studentService.GetStudentById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No student found!");
        }

        [HttpPost("Add-Student")]
        public ActionResult AddStudent(StudentDto student)
        {
            var studentEntity = _mapper.Map<Student>(student);
            studentEntity.University = UniversityRepository.GetById(student.UniversityId);
            studentEntity.Courses = new List<Course>();
            studentEntity.Courses = CourseRepository.Query(X => student.CoursesIds.Contains(X.CourseId)).ToList();

            _studentService.AddStudent(studentEntity);
            return Ok("Student added!");

        }

        [HttpDelete("Delete-Student-By-Id")]
        public ActionResult DeleteStudentById(int studentId)
        {
            _studentService.DeleteStudentById(studentId);
           
            return Ok();
        }

    }
}
