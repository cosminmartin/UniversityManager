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
    public class ProfessorController : Controller
    {
        private readonly IProfessorService _professorService;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<University> UniversityRepository;
        private readonly IGenericRepository<Course> CourseRepository;

        public IProfessorService ProfessorService => _professorService;

        public ProfessorController(IProfessorService professorService, IMapper mapper, IGenericRepository<University> universityRepository, IGenericRepository<Course> courseRepository)
        {
            _professorService = professorService;
            _mapper = mapper;
            UniversityRepository = universityRepository;
            CourseRepository = courseRepository;         
        }


        [HttpGet("Get-all-professors")]
        public ActionResult GetAllProfessors()
        {
            var result = _professorService.GetAllProfessors();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No professors found!");
        }


        [HttpGet("Get-professor-by:{id}")]
        public ActionResult GetProfessorById(int id)
        {
            var result = _professorService.GetProfessorById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No professor found!");
        }

        [HttpPost("Add-Professor")]
        public ActionResult AddProfesor(ProfessorDto professor)
        {
            var professorEntity = _mapper.Map<Professor>(professor);
            professorEntity.University = UniversityRepository.GetById(professor.UniversityId);
            professorEntity.Courses = new List<Course>();
            professorEntity.Courses = CourseRepository.Query(X => professor.CoursesIds.Contains(X.CourseId)).ToList();

            _professorService.AddProfessor(professorEntity);
            return Ok("Professor added!");

        }

   
        [HttpDelete("Delete-Professor-By-Id")]
        public ActionResult DeleteProfessorById(int professorId)
        {
            _professorService.DeleteProfessorById(professorId);
           
            return Ok();
        }

        
    }
}


/* OLD / no services
        [HttpPatch("Update-professor")]
        public ActionResult UpdateProfessor(Professor professor)
        {
            ProfessorService.UpdateProfessor(professor);
            return Ok("Update completed!");
        }
        */




        /*
        private IGenericRepository<Professor> repository = null;
        public ProfessorController(IGenericRepository<Professor> repository)
        {
            this.repository = repository;
        }

         old/no services
        [HttpGet("Get-Professors")]
        public ActionResult GetProfessor()
        {
            var professors = repository.GetAll();
            return Ok(professors);
        }
        */

        /* old/no services
        [HttpPost("Add-Professor")]
        public ActionResult CreateProfessor(ProfessorDto professor)
        {
            var professorEntity = new Professor(professor.FirstName, professor.LastName, professor.UniversityId);

            repository.Insert(professorEntity);
            repository.Save();
            return Ok();
        }
        */

        /*
        [HttpGet("Get-Professor-By-Id")]
        public ActionResult GetProfessorById(int ProfessorId)
        {
            Professor professor = repository.GetById(ProfessorId);
            return Ok(professor);
        }

        [HttpPatch("Edit-Professor")]
        public ActionResult EditProfessor(Professor professor)
        {
            if (ModelState.IsValid)
            {
                repository.Update(professor);
                repository.Save();
                return RedirectToAction("Index", "Professor");
            }
            else
            {
                return Ok(professor);
            }
        }
       
        [HttpDelete("Delete-Professor-By-Id")]
        public ActionResult DeleteProfessorById(int ProfessorId)
        {
            repository.Delete(ProfessorId);
            repository.Save();
            return Ok();
        }
        */