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
    public class CourseInstructorsController : Controller
    {
        ICourseInstructorService _courseInstructorService;
        ICourseService _courseService;
        IUserService _userService;

        public CourseInstructorsController(ICourseInstructorService courseInstructorService, ICourseService courseService, IUserService userService)
        {
            _courseInstructorService = courseInstructorService;
            _courseService = courseService;
            _userService = userService;
        }

        //[HttpPost("add")]
        public IActionResult Add(Course course, int[] userId)
        {
            var result = _courseService.Add(course);
            foreach (var id in userId)
            {
                User user = _userService.GetById(id).Data;
                if (!user.Status.Equals("Admin"))
                {
                    user.Status = "CourseInstructor";
                    _userService.Update(user);
                }
                _courseInstructorService.Add(new CourseInstructor { UserId = id, CourseId = course.Id });
            }
            if (result.Success)
            {
                return RedirectToRoute(new
                {
                    controller = "Home",
                    action = "Index"
                });
            }
            return BadRequest(result);

            //var result = _courseInstructorService.Add(courseInstructor);
            //if (result.Success)
            //{
            //    return Ok(result);
            //}
            //return BadRequest(result);
            return null;
        }

        //[HttpPost("update")]
        public IActionResult Update(CourseInstructor courseInstructor)
        {
            var result = _courseInstructorService.Update(courseInstructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("delete")]
        public IActionResult Delete(CourseInstructor courseInstructor)
        {
            var result = _courseInstructorService.Delete(courseInstructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _courseInstructorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _courseInstructorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetCourseInstructorByCourseId")]
        public IActionResult GetCourseInstructorByCourseId(int id)
        {
            var result = _courseInstructorService.GetCourseInstructorByCourseId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetCourseInstructorByUserId")]
        public IActionResult GetCourseInstructorByUserId(int id)
        {
            var result = _courseInstructorService.GetCourseInstructorByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetCourseInstructorDetails")]
        public IActionResult GetCourseInstructorDetails()
        {
            var result = _courseInstructorService.GetCourseInstructorDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetCourseInstructorDetailsByCourseInstructorId")]
        public IActionResult GetCourseInstructorDetailsByCourseInstructorId(int id)
        {
            var result = _courseInstructorService.GetCourseInstructorDetailsByCourseInstructorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetCourseInstructorDetailsByCourseId")]
        public IActionResult GetCourseInstructorDetailsByCourseId(int id)
        {
            var result = _courseInstructorService.GetCourseInstructorDetailsByCourseId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetCourseInstructorDetailsByUserId")]
        public IActionResult GetCourseInstructorDetailsByUserId(int id)
        {
            var result = _courseInstructorService.GetCourseInstructorDetailsByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
