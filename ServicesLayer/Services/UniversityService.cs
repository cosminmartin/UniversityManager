using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using RepositoryLayer.GenericRepository;

namespace ServicesLayer.Services
{
    public class UniversityService : IUniversityService
    {
        private IGenericRepository<University> _universityRepository;
        public UniversityService(IGenericRepository<University> universityRepository)
        {
            _universityRepository = universityRepository;
        }

        public IEnumerable<University> GetAllUniversities()
        {
            return _universityRepository.GetAll();
        }

        public University GetUniversityById(int id)
        {
            return _universityRepository.GetById(id);
        }

        public void AddUniversity(University university)
        {
            _universityRepository.Insert(university);
            _universityRepository.Save();
        }

        public void UpdateUniversity(University university)
        {
            _universityRepository.Update(university);
        }

        public void DeleteUniversityById(int universityId)
        {

            _universityRepository.Delete(universityId);
            _universityRepository.Save();
        }

    }
}
