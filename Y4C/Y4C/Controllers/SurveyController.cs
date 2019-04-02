using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Y4C.Models;
using Microsoft.EntityFrameworkCore;

namespace Y4C.Controllers
{
    public class SurveyController : Controller
    {
        AddContentDBContext DBContext;
        public SurveyController(AddContentDBContext context)
        {
            DBContext = context;
        }
        
        public IActionResult Index()
        {
            IList<Questions> questions = DBContext.Questions.Include(q => q.Surveys).ToList();
            return View(questions);
        }

        [HttpGet]
        public ActionResult CreateSurvey()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateSurvey(Survey newSurvey)
        {
            Request.Form["QuestionOne"].ToString();
            if(ModelState.IsValid) 

            {
                DBContext.Add(newSurvey);
                DBContext.SaveChanges();
            }
        
            else
            {
                throw new Exception();
            }
            return RedirectToAction( "ViewSurvey", new { id = newSurvey.Id });
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Questions newQuestion)
        {
            if (ModelState.IsValid)
            {
                DBContext.Add(newQuestion);
                DBContext.SaveChanges();

            }
            else
            {
                throw new Exception();
            }

            return RedirectToAction("ViewSurvey");
        }

        public ActionResult ViewSurvey()
        {
            return View();
        }
    }
}