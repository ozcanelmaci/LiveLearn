using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseManagement.Models.Business.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseManagement.Controllers
{
    public class CourseImagesController : Controller
    {
        public static IWebHostEnvironment _webHostEnvironment;

        ICourseImageService _courseImageService;

        public CourseImagesController(ICourseImageService courseImageService, IWebHostEnvironment webHostEnvironment)
        {
            _courseImageService = courseImageService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Images"))] IFormFile file, [FromForm] CourseImage courseImage)
        {
            string path = _webHostEnvironment.WebRootPath + "\\Images\\";
            var newGuidPath = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (FileStream fileStream = System.IO.File.Create(path + newGuidPath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            if (file == null)
            {
                courseImage.ImagePath = path + "default.png";
            }
            var result = _courseImageService.Add(new CourseImage
            {
                CourseId = courseImage.CourseId,
                Link = courseImage.Link,
                ImagePath = newGuidPath
            });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("update")]
        public IActionResult Update(CourseImage courseImage)
        {
            var result = _courseImageService.Update(courseImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("delete")]
        public IActionResult Delete(CourseImage courseImage)
        {
            var result = _courseImageService.Delete(courseImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _courseImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _courseImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("GetByCourseId")]
        public IActionResult GetByCourseId(int courseId)
        {
            var result = _courseImageService.GetByCourseId(courseId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
