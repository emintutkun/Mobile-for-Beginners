using OgrenciProjeCodeFirst.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciProjeCodeFirst.Controllers
{
    public class StudentController : Controller
    {
        OgrenciContext db = new OgrenciContext();
        // GET: Student
        public ActionResult List()
        {
            var students = db.Set<Student>().Select(x=> new StudentDTO);
            return View(students);
        }
    }
}