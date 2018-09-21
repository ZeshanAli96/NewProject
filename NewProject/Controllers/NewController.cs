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

        public IActionResult Index()
        {
           
            return View();
        }
    }
}