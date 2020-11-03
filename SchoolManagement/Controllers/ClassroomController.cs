﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Services.Interfaces;
using SchoolManagement.Services.ViewModels;
using SchoolManagement.Services.ViewModels.Clasroom;

namespace SchoolManagement.Controllers
{
    public class ClassroomController : Controller
    {
        private readonly IClassroomService classroomService;

        public ClassroomController(IClassroomService classroomService)
        {
            this.classroomService = classroomService;
        }
        public IActionResult Overview()
        {
            var classrooms = classroomService.GetAll();
            return View(classrooms);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var model = new ClassroomViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ClassroomViewModel model)
        {
            if (ModelState.IsValid)
            {
                ActionMessage response = classroomService.Create(model);
                return RedirectToAction("ActionMessage", "Dashboard", response);
            }
            return View(model);
        }
    }
}
