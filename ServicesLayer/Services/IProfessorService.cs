using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using ServicesLayer.Dtos;

namespace ServicesLayer.Services
{
    public interface IProfessorService
    {
        IEnumerable<Professor> GetAllProfessors();
        Professor GetProfessorById(int id);
        void AddProfessor(Professor professor);
        void UpdateProfessor(Professor professor);

        void DeleteProfessorById(int professorId);
    }
}
