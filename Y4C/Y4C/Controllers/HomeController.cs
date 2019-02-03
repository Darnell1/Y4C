using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Y4C.Models;

namespace Y4C.Controllers
{
    public class HomeController : Controller
    {
        AddContentDBContext DBcontext;
        public HomeController(AddContentDBContext context)
        {
            DBcontext = context;
        }
        
        public ActionResult HomePage()
        {
            return View(DBcontext.AC.ToList());
        } 
        public ActionResult AddContent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(AddContent add)
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
            return RedirectToAction(nameof(ThankYou), new { id = add.Id });
        }
        
        public ActionResult ThankYou()
        {
            return View();
        }
        //public ViewResult PlayVideo() => View();

        public ActionResult PlayVideo(int id)
        {
            var video = DBcontext.AC.FirstOrDefault(ac => ac.Id == id);
            if (video == null)
            {
                throw new Exception("Video does not exist.");
            }

            return View(viewName: nameof(PlayVideo), model: video);
        }

        

    }
}
