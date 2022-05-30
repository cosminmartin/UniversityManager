using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using RepositoryLayer.GenericRepository;

namespace ServicesLayer.Services
{
    public class CourseService : ICourseService
    {
        private IGenericRepository<Course> _courseRepository;
        public CourseService(IGenericRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();
        }

        public Course GetCourseById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void AddCourse(Course course)
        {
            _courseRepository.Insert(course);
            _courseRepository.Save();
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.Update(course);
        }

        public void DeleteCourseById(int courseId)
        {

            _courseRepository.Delete(courseId);
            _courseRepository.Save();
        }

    }
}
