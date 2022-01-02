using OnlineCourseManagement.Models.Business.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseManagement.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CoursesController : Controller
    {
        ICourseService _courseService;
        ICategoryService _categoryService;
        IUserService _userService;
        ICourseInstructorService _courseInstructorsService;

        public CoursesController(ICourseService courseService, ICategoryService categoryService, IUserService userService,
            ICourseInstructorService courseInstructorService)
        {
            _courseService = courseService;
            _categoryService = categoryService;
            _userService = userService;
            _courseInstructorsService = courseInstructorService;
        }

        public IActionResult AddCourse()
        {
            ViewData["Categories"] = _categoryService.GetAll().Data;
            ViewData["Users"] = _userService.GetAll().Data;

            return View();
        }

        public IActionResult DeleteCourse(int id)
        {
            Course courseToBeDeleted = _courseService.GetById(id).Data;
            Delete(courseToBeDeleted);
            return RedirectToRoute(new
            {
                controller = "Home",
                action = "Index"
            });
            //return View();
        }

        //[HttpPost("add")]
        public IActionResult Add(Course course)
        {
            var result = _courseService.Add(course);
            if (result.Success)
            {
                return RedirectToRoute(new
                {
                    controller = "Home",
                    action = "Index"
                });
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Course course)
        {
            var result = _courseService.Update(course);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("delete")]
        public IActionResult Delete(Course course)
        {
            var result = _courseService.Delete(course);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _courseService.GetAll();
            if (result.Success)
            {
                ViewData["Courses"] = result.Data;
                ViewData["CourseInstructorService"] = _courseInstructorsService;

                return View();
            }
            return BadRequest(result);
        }
        public int getSize() {
            var result = _courseService.GetAll();
            if (result.Success)
            {
                return result.Data.Count();
            }
            return 0;
        }

        //[HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _courseService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetCoursesByCategoryId")]
        public IActionResult GetCoursesByCategoryId(int id)
        {
            var result = _courseService.GetCoursesByCategoryId(id);
            if (result.Success)
            {
                ViewData["Data"] = result.Data;
                ViewData["CourseInstructorService"] = _courseInstructorsService;

                return View();
            }
            return BadRequest(result);
        }

        //[HttpGet("GetCourseDetails")]
        public IActionResult GetCourseDetails()
        {
            var result = _courseService.GetCourseDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetCourseDetailsByCategoryId")]
        public IActionResult GetCourseDetailsByCategoryId(int id)
        {
            var result = _courseService.GetCourseDetailsByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetCourseDetailsByCourseId")]
        public IActionResult GetCourseDetailsByCourseId(int id)
        {
            var result = _courseService.GetCourseDetailsByCourseId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
