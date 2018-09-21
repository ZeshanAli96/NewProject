using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewProject.Models;

namespace NewProject.Controllers
{
    public class NewController : Controller
    {
        NewProjectContext _ORM = null;
        public NewController(NewProjectContext ORM) {
            _ORM = ORM;

        }
        [HttpGet]
        public IActionResult AddStudent() {

            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student S) {
            _ORM.Add(S);
            _ORM.SaveChanges();
            ModelState.Clear();
            ViewBag.message = "Record Added Successfully"; 
                          return View();
        }

        public IActionResult Index()
        {
           
            return View();
        }
    }
}