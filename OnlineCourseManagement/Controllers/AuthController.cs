using OnlineCourseManagement.Models.Business.Abstract;
using OnlineCourseManagement.Models.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineCourseManagement.Models.Entities.Concrete;

namespace OnlineCourseManagement.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        public static User user = null;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        public IActionResult SignInForm()
        {
            return View();
        }

        public IActionResult LogInForm()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            user = null;
            return RedirectToRoute(new
            {
                controller = "Home",
                action = "Index"
            });
        }

        //[HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }
            if (userToLogin.Success)
            {
                user = userToLogin.Data;
                return RedirectToRoute(new
                {
                    controller = "Home",
                    action = "Index"
                });
                //return Ok(userToLogin);
            }

            return BadRequest(userToLogin.Message);
        }

        //[HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            userForRegisterDto.Status = "User";
            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            if (registerResult.Success)
            {
                return RedirectToRoute(new
                {
                    controller = "Auth",
                    action = "LogInForm"
                });
            }

            return BadRequest(registerResult.Message);
        }
    }
}
