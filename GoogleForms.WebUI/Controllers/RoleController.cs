using GoogleForms.DTOs;
using GoogleForms.DTOs.ControllerDtos;
using GoogleForms.Entities.UserEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GoogleForms.WebUI.Controllers
{
    [Authorize(Roles ="Admin")]

    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var list=_roleManager.Roles.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View(new ControllerCreateRoleDto());
        }
        [HttpPost]
        public async Task<IActionResult> Create(ControllerCreateRoleDto dto)
        {
            if (ModelState.IsValid)
            {
             var result=  await _roleManager.CreateAsync(new AppRole()
                {
                    Name = dto.Name,
                });
                if (result.Succeeded)
                {
                    return RedirectToAction("Home", "Form");
                }
               
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                
            }
            return View(dto);
        }
    }
}
