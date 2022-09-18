using GoogleForms.BLL.Interfaces;
using GoogleForms.DTOs;
using GoogleForms.DTOs.ControllerDtos;
using GoogleForms.Entities.UserEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace GoogleForms.WebUI.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            
        }

        public async Task<IActionResult> LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(ControllerLoginAccountDto dto)
        {
            if (ModelState.IsValid)
            {
                var signInResult =
                    await _signInManager.PasswordSignInAsync(dto.Email, dto.Password, dto.RememberMe, false);
                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "form");
                }
            }
            return View(dto);
        }

        public async Task<IActionResult> CreateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(ControllerCreateAccountDto dto)
        {
            
            AppUser appUser = new()
            {
                Email = dto.Email,
                Name = dto.Name,
                Surname = dto.Surname,
                UserName= dto.Email,
            };

          var identityResult= await _userManager.CreateAsync(appUser, dto.Password);
            if (identityResult.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(appUser.UserName);
                if (_roleManager.Roles.Count() == 0)
                {
                    await _roleManager.CreateAsync(new AppRole()
                    {
                        Name = "Member"
                    });
                    await _roleManager.CreateAsync(new AppRole()
                    {
                        Name = "Admin"
                    });

                }
                await _userManager.AddToRoleAsync(user, "Member");
                return RedirectToAction("LogIn");
            }
            foreach (var error in identityResult.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(dto);
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("home", "form");
            
        }


    }
}
