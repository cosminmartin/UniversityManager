using System;

using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;



namespace RepositoryLayer.Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            //using DataContext myContext = new Context();

            //Afisati in ordine alfabetica studentii

            /*
            var orderAlphabetically = from s in myContext.Students
                                orderby s.LastName descending
                                select s;
            */



            // Change name (5) //Alegeti un student si schimbati-i numele de familie (am schimbat prenumele, dar e acelasi principiu)
            /*
            var newName = myContext
                .Students
                .FirstOrDefault(s => s.StudentId == 9);

            newName.FirstName = "Andrei";

            myContext.SaveChanges();
            */

            // Add Medie

            /*
            var newMedie = myContext
                .Students
                .FirstOrDefault(s => s.StudentId == 8);

            newMedie.Medie = 10;

            myContext.SaveChanges();
            */

            //Add YearOfStudy to Course

            /*
            var addYearToCourse = myContext
                .Courses
                .FirstOrDefault(c => c.CourseId == 5);

            addYearToCourse.YearOfStudy = 3;

            myContext.SaveChanges();
            */

            /*
            var university = new University()
            {
                UniversityName = "Universitatea Cuza"
            };
            myContext.Universities.Add(university);
            myContext.SaveChanges();
            

            
            myContext.Students.Add(new Student()
            {
                FirstName = "Cosmin",
                LastName = "Martin",
                CNP = 1930510,
                //UniversityId = university.Id, //university does not exist in the current context
                UniversityId = 1, 
                Medie = 8
            });
            myContext.SaveChanges();
            */

            /*
            var chanceUniName = myContext.Universities.FirstOrDefault(uni => uni.Id == 2);
            chanceUniName.Nume = "Universitatea Alecsandri";
            myContext.SaveChanges();
            */


            //Add course

            /*
            var course = new Course()
            {
                CourseName = "Computer security"
            };
            myContext.Courses.Add(course);
            myContext.SaveChanges();
            */


            /*
            myContext.Professors.Add(new Professor()
            {
                FirstName = "Alexandru",
                LastName = "Manole",
                UniversityId = 1
            });
            myContext.SaveChanges();

            myContext.Professors.Add(new Professor()
            {
                FirstName = "Simona",
                LastName = "Radulescu",
                UniversityId = 1
            });
            myContext.SaveChanges();
            */


            //Add Course to Professor

            /*
            var addProfIdToCourse = myContext.Courses
                .FirstOrDefault(c => c.CourseId == 5);

            addProfIdToCourse.Professors = new List<Professor> { myContext.Professors
                .FirstOrDefault(p => p.ProfessorId == 1) }; 
                
               
            myContext.SaveChanges();
            */

            //Add Course to Student

            /*
            var addStudentIdToCourse = myContext.Courses
             .FirstOrDefault(c => c.CourseId == 3);

            addStudentIdToCourse.Students = new List<Student> { myContext.Students
                .FirstOrDefault(p => p.StudentId == 5) };


            myContext.SaveChanges();
            */



            /*
            myContext.Professors.Add(new Professor()
            {
                FirstName = "Andrei",
                LastName = "Popa",
                UniversityId = 2,
                CourseName = "Math"
            });
            myContext.SaveChanges();
            */

            /*
            myContext.Students.Add(new Student()
            {
                FirstName = "Ion",
                LastName = "Barbarasa",
                CNP = 1940105,
                UniversityId = 2
            });
            myContext.SaveChanges();
            */

            /*
            myContext.Students.Add(new Student()
            {
                FirstName = "Iulian",
                LastName = "Chitu",
                CNP = 1930806,
                UniversityId = 2
            });
            myContext.SaveChanges();
            */


        }
    }

}