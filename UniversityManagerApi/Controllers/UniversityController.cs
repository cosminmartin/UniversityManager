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
    public class UniversityController : Controller
    {
        private readonly IUniversityService _universityService;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Course> CourseRepository;

        public IUniversityService UniversityService => _universityService;

        public UniversityController(IUniversityService universityService, IMapper mapper, IGenericRepository<Course> courseRepository)
        {
            _universityService = universityService;
            _mapper = mapper;
            CourseRepository = courseRepository;
        }


        [HttpGet("Get-all-universities")]
        public ActionResult GetAllUniversities()
        {
            var result = _universityService.GetAllUniversities();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No universities found!");
        }


        [HttpGet("Get-university-by:{id}")]
        public ActionResult GetUniversityById(int id)
        {
            var result = _universityService.GetUniversityById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No university found!");
        }

        /*
        [HttpPost("Add-University")]
        public ActionResult AddUniversity(UniversityDto university)
        {
          
        }
        */

        [HttpDelete("Delete-University-By-Id")]
        public ActionResult DeleteUniversityById(int universityId)
        {
            _universityService.DeleteUniversityById(universityId);

            return Ok();
        }


    }
}
