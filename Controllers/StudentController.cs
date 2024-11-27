using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_InMemory_CRUD_Demo.Models;
using MVC_InMemory_CRUD_Demo.Service;
namespace MVC_InMemory_CRUD_Demo.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = StudentService.GetAll();
            return View(students);
        }
                [HttpGet]
 
        public IActionResult Details(int id){
            var student = StudentService.GetStudentById(id);
            return View(student);
        }
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student newstudent){
            StudentService.AddStudent(newstudent);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id){
            var student = StudentService.GetStudentById(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student updatedStudent){
            StudentService.Update(updatedStudent);
            return RedirectToAction("Index");
        }
        // [HttpGet]
        // public IActionResult Delete(int id){
        //     var student = StudentService.GetStudentById(id);
        //     return View(student);
        // }

        [HttpGet]
        public IActionResult Delete(int id){
            StudentService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}