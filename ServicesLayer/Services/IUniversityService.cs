using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using ServicesLayer.Dtos;

namespace ServicesLayer.Services
{
    public interface IUniversityService
    {
        IEnumerable<University> GetAllUniversities();
        University GetUniversityById(int id);
        void AddUniversity(University university);
        void UpdateUniversity(University university);

        void DeleteUniversityById(int university);
    }
}
