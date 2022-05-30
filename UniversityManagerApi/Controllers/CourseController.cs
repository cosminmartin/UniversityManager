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
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<University> UniversityRepository;
        
        public ICourseService CourseService => _courseService;

        public CourseController(ICourseService courseService, IMapper mapper, IGenericRepository<University> universityRepository)
        {
            _courseService = courseService;
            _mapper = mapper;
            UniversityRepository = universityRepository;
       
        }


        [HttpGet("Get-all-courses")]
        public ActionResult GetAllCourses()
        {
            var result = _courseService.GetAllCourses();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No courses found!");
        }


        [HttpGet("Get-course-by:{id}")]
        public ActionResult GetCourseById(int id)
        {
            var result = _courseService.GetCourseById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No course found!");
        }

        /*
        [HttpPost("Add-Course")]
        public ActionResult AddCourse(CourseDto course)
        {
            var courseEntity = _mapper.Map<Course>(course);
            courseEntity.University = UniversityRepository.GetById(course.UniversityId);
            courseEntity.Courses = new List<Course>();
            courseEntity.Courses = CourseRepository.Query(X => professor.CoursesIds.Contains(X.CourseId)).ToList();

            _professorService.AddProfessor(professorEntity);
            return Ok("Professor added!");

        }
        */

        [HttpDelete("Delete-Course-By-Id")]
        public ActionResult DeleteCourseById(int courseId)
        {
            _courseService.DeleteCourseById(courseId);

            return Ok();
        }


    }
}
