using Microsoft.AspNet.Identity;
using NguyenHuuNhan_2011065282.Models;
using NguyenHuuNhan_2011065282.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenHuuNhan_2011065282.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create()
        {
           
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
        public ActionResult Create(CourseViewModel VM) 
        {
            if(!ModelState.IsValid)
            {
                VM.Categories = _dbContext.Categories.ToList();
                return View("Create" ,VM);    
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = VM.GetDateTime(),
                CategoryID = VM.Category,
                Place = VM.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}