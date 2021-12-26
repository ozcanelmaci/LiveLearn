using OnlineCourseManagement.Models.Business.Abstract;
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
    public class AuthController : Controller
    {
        private IAuthService _authService;

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
                return Ok(userToLogin);
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

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            if (registerResult.Success)
            {
                return Ok(registerResult.Data);
            }

            return BadRequest(registerResult.Message);
        }
    }
}
