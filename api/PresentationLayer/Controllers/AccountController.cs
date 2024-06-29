using api.ApplicationLayer.Dtos.LoginDto;
using api.ControlLayer.Interfaces;
using api.DataLayer.Dtos.AccountDto;
using api.DataLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.ControlLayer.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController(UserManager<AppUser> userManager, ITokenService tokenService, SignInManager<AppUser> signInManager) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                var appUser = new AppUser
                {
                    UserName = registerDto.Username,
                    Email = registerDto.Email
                };
                var createUser = await userManager.CreateAsync(appUser, registerDto.Password);
                if (createUser.Succeeded)
                {
                    var roleResult = await userManager.AddToRoleAsync(appUser, "User");
                    if (roleResult.Succeeded)
                    {
                        return Ok(new UserDto
                        {
                            userName = appUser.UserName,
                            email = appUser.Email,
                            token = tokenService.CreateToken(appUser)
                        });
                    }
                    else
                    {
                        return StatusCode(500, roleResult.Errors);
                    }
                }
                else
                {
                    return StatusCode(500, createUser.Errors);
                }
            }
            catch (Exception) { return StatusCode(500, "An error occurred"); }


        }


        [HttpPost("login")]
        public async Task<IActionResult> login(LoginDto loginDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = await userManager.Users.FirstOrDefaultAsync(x => x.UserName == loginDto.username);
            if (user == null) return Unauthorized("Invalid username!");

            var result = await signInManager.CheckPasswordSignInAsync(user, loginDto.password, false);

            if (!result.Succeeded) return Unauthorized("Invalid username or password!");
            return Ok(new UserDto
            {
                userName = user.UserName,
                email = user.Email,
                token = tokenService.CreateToken(user)
            });

        }
    }
}