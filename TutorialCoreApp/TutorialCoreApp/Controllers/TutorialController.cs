using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TutorialCoreApp.Models;

namespace TutorialCoreApp.Controllers
{
    public class TutorialController : Controller
    {
        TutorialDbContext _tutorialDbContext;
        public TutorialController(TutorialDbContext tutorialDbContext)
        {
            _tutorialDbContext = tutorialDbContext;
        }
        public IActionResult Index()
        {
            var tutorialList = _tutorialDbContext.tutorial.ToList();
            return View(tutorialList);
        }
        public IActionResult TutorialEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TutorialEntry(Tutorial tutorial)
        {
            _tutorialDbContext.tutorial.Add(tutorial);
            _tutorialDbContext.SaveChanges();
            ViewBag.message = "Tutorial details saved successfully";
            return View();
        }
        public IActionResult EditTutorial(int TutorialId)
        {
            return View();
        }
        public IActionResult DeleteTutorial(int TutorialId)
        {
            return View();
        }
    }
}