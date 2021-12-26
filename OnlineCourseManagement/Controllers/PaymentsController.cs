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
    public class PaymentsController : Controller
    {
        IPaymentService _paymentService;
        ICourseService _courseService;

        public PaymentsController(IPaymentService paymentService, ICourseService courseService)
        {
            _paymentService = paymentService;
            _courseService = courseService;
        }

        //[HttpPost("add")]
        public IActionResult Add(Payment payment)
        {
            var result = _paymentService.AddPayment(payment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("getCoursesOfUser")]
        public IActionResult GetCoursesOfUser(int id)
        {
            var result = _paymentService.GetPaymentsByUserId(id);
            List<CourseDetailDto> coursesOfUser = new List<CourseDetailDto>();
            foreach (var item in result.Data)
            {
                coursesOfUser.Add(_courseService.GetCourseDetailsByCourseId(item.CourseId).Data.ElementAt<CourseDetailDto>(0));
            }
            if (result.Success)
            {
                return Ok(coursesOfUser);
            }
            return BadRequest(result);
        }
    }
}
