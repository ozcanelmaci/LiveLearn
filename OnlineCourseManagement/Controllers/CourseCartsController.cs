using OnlineCourseManagement.Models.Business.Abstract;
using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
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
    public class CourseCartsController : Controller
    {

        ICourseCartService _courseCartService;
        ICourseService _courseService;

        public CourseCartsController(ICourseCartService courseCartService, ICourseService courseService)
        {
            _courseCartService = courseCartService;
            _courseService = courseService;
        }

        public IActionResult AddCourseCart(int id, string controllerName, string actionName, int categoryId)
        {
            CourseCart courseCart = new CourseCart();
            courseCart.CourseId = id;
            courseCart.UserId = OnlineCourseManagement.Controllers.AuthController.user.Id;
            Add(courseCart);
            if (categoryId == 0)
            {
                return RedirectToRoute(new
                {
                    controller = controllerName,
                    action = actionName
                });
            }
            else
            {
                return RedirectToRoute(new
                {
                    controller = controllerName,
                    action = actionName,
                    id = categoryId
                });
            }
            
        }

        public IActionResult DeleteFromMyCourses(int id)
        {
            CourseCart courseCart = _courseCartService.GetById(id).Data;
            Delete(courseCart);
            return RedirectToRoute(new
            {
                controller = "CourseCarts",
                action = "GetCourseCartsByUserId",
                id = OnlineCourseManagement.Controllers.AuthController.user.Id,
            });
        }


        //[HttpPost("add")]
        public IActionResult Add(CourseCart courseCart)
        {
            var result = _courseCartService.Add(courseCart);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        public IActionResult Delete(CourseCart courseCart)
        {
            var result = _courseCartService.Delete(courseCart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("getCoursesOfUser")]
        public IActionResult GetCourseCartsByUserId(int id)
        {
            var result = _courseCartService.GetCourseCartsByUserId(id);
            if (result.Success)
            {
                ViewData["MyCourseCart"] = result.Data;
                ViewData["CourseService"] = _courseService;
                return View();
            }
            return BadRequest(result);
        }
    }
}
