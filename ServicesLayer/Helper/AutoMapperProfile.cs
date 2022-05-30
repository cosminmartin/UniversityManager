using AutoMapper;
using DomainLayer.Models;
using ServicesLayer.Dtos;

namespace ServicesLayer.UniversityProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProfessorDto, Professor>();
            CreateMap<Professor, ProfessorDto>();
            CreateMap<StudentDto, Student>();
            CreateMap<Student, StudentDto>();
            CreateMap<CourseDto, Course>();
            CreateMap<Course, CourseDto>();
            CreateMap<UniversityDto, University>();
            CreateMap<University, UniversityDto>();
        }
    }
}
