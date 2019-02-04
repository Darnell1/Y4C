using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Y4C.Models;
using System.Data;

namespace Y4C.Controllers
{
    public class ManageController : Controller
    {
        AddContentDBContext DBcontext;
        public ManageController(AddContentDBContext context)
        {
            DBcontext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ManageContent()
        {
            return View(DBcontext.AC.ToList());
        }

        public ActionResult ContentDetails(int id = 0)
        {
            return View(DBcontext.AC.Find(id));
        }

        public ActionResult DeleteContent(int id = 0)
        {
            return View(DBcontext.AC.Find(id));
        }

        [HttpPost, ActionName("DeleteContent")]
        public ActionResult DeleteConfirm(int id)
        {
            AddContent post = DBcontext.AC.Find(id);
            DBcontext.AC.Remove(post);
            DBcontext.SaveChanges();
            return RedirectToAction("ManageContent");
        }

        public ActionResult Archive(int id = 0)
        {
            return View(DBcontext.AC.Find(id));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Archive(AddContent content)
        {
            DBcontext.Entry(content).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DBcontext.SaveChanges();
            return RedirectToAction("ManageContent");

        }

        public ActionResult Edit(int id = 0)
        {
            return View(DBcontext.AC.Find(id));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(AddContent content)
        {
            DBcontext.Entry(content).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DBcontext.SaveChanges();
            return RedirectToAction("ManageContent");

        }



    }
}