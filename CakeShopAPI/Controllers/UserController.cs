﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeShopAPI.Services;
using CakeShopAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using CakeShopAPI.Data;
using Microsoft.Extensions.Options;
namespace CakeShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Login(string phone, string password)
        {
            //try
            //{
                return Ok(_userRepository.Login(phone, password));
            //}
            //catch
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError);
            //}
        }
    }
}
