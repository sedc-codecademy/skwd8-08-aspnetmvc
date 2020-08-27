using System;
using System.Linq;
using Class02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class02.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.students = DataHelper.Students;
            return View();
        }

        public IActionResult Details(int id)
        {
            var student = DataHelper.Students.FirstOrDefault(x => x.Id == id);
            if(student == null)
                throw new Exception("Student not found");

            //Using dynamic object is not a good practice
            student.Other = "test";

            //ViewBag is dynamic bag for sending data between controllers and views, and it is a bad practice.
            //We will learn other ways of sending data between controllers and views
            ViewBag.StudentDetails = student;
            return View();
        }

        [Route("ucenici/name/{name?}")]
        public IActionResult DetailsByName(string name)
        {
            return View();
        }

        [Route("student/nameAndId/{name}/{id}")]
        public IActionResult DetailsByNameAndId(string name, int id)
        {
            return View();
        }
    }
}
