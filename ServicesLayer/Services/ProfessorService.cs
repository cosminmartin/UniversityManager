using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using RepositoryLayer.GenericRepository;

namespace ServicesLayer.Services
{
    public class ProfessorService : IProfessorService
    {
        private IGenericRepository<Professor> _professorRepository;
        public ProfessorService(IGenericRepository<Professor> professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public IEnumerable<Professor> GetAllProfessors()
       {
           return _professorRepository.GetAll();
       }
       
        public Professor GetProfessorById(int id)
        {
           return _professorRepository.GetById(id);
        }

        public void AddProfessor(Professor professor)
        {
            _professorRepository.Insert(professor);
            _professorRepository.Save();
        }

        public void UpdateProfessor(Professor professor)
        {
            _professorRepository.Update(professor);
        }
  
        public void DeleteProfessorById(int professorId)
        {
    
            _professorRepository.Delete(professorId);
            _professorRepository.Save();
        }
        
    }
}
