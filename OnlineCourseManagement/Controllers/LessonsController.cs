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
    public class LessonsController : Controller
    {
        ILessonService _lessonService;

        public LessonsController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        //[HttpPost("add")]
        public IActionResult Add(Lesson lesson)
        {
            var result = _lessonService.Add(lesson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("update")]
        public IActionResult Update(Lesson lesson)
        {
            var result = _lessonService.Update(lesson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("delete")]
        public IActionResult Delete(Lesson lesson)
        {
            var result = _lessonService.Delete(lesson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _lessonService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _lessonService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetLessonDetails")]
        public IActionResult GetLessonDetails()
        {
            var result = _lessonService.GetLessonDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetLessonDetailsByCourseId")]
        public IActionResult GetLessonDetailsByCourseId(int id)
        {
            var result = _lessonService.GetLessonDetailsByCourseId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
