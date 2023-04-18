using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LleytonExcellentForwarders.Api.Data;
using LleytonExcellentForwarders.Api.Models;
using LleytonExcellentForwarders.Core;

namespace LleytonExcellentForwarders.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser>          _userManager;
        private readonly SignInManager<IdentityUser>        _signInManager;
        private readonly ILogger<AuthenticationController>  _logger;

        public AuthenticationController(UserManager<IdentityUser>   userManager,
                              SignInManager<IdentityUser>           signInManager,
                              ILogger<AuthenticationController>     logger){
            _userManager    = userManager;
            _signInManager  = signInManager;
            _logger         = logger;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync(UserModel model){
            if (ModelState.IsValid){
                var user = new IdentityUser { UserName = model.Email, Email = model.Email, EmailConfirmed = true };
                var result = await _userManager.CreateAsync(user, model.Password);
                
                return Ok(result);
            }else{
                return BadRequest();
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync(UserModel model){
            if (ModelState.IsValid){
                var result =
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, true,
                        lockoutOnFailure: false);
                if (result.Succeeded){
                    var user = _userManager.FindByEmailAsync(model.Email);
                    var token = Token.GenerateJsonWebToken();
                    return Ok(new{
                        UserId  = user.Result.Id,
                        Token   = token,
                        Expires = DateTime.Now.AddHours(3),
                    });
                }
            }

            return BadRequest();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllAsync(){
            var users = new List<UserModel>{
                new UserModel{Email = "bluei2@outlook.com"}, new UserModel{Email = "bluei2@gmail.com"}
            };

            return Ok(users.ToList());
        }
    }
}
