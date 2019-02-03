using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Y4C.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Y4C.Controllers
{
    public class AccountController : Controller
    {
        AddContentDBContext DBcontext;
        public AccountController(AddContentDBContext context)
        {
            DBcontext = context;
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Account add)
        {

            if (ModelState.IsValid)
            {
                DBcontext.Add(add);
                DBcontext.SaveChanges();

            }
            else
            {
                throw new Exception();
            }
            return RedirectToAction(nameof(StudentDashboard));
        }

        public IActionResult Login()
        {
            return View();
        }


        public ActionResult StudentDashboard()
        {
            return View();
        }

        public ActionResult AdminDashboard()
        {
            return View();
        }

    }
}