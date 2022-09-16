using GoogleForms.DAL.Context;
using GoogleForms.Entities.UserEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;

namespace GoogleForms.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        
        public UserController(UserManager<AppUser> userManager )
        {
            _userManager = userManager;
            //_context = context;
        }

        public async Task<IActionResult> Index()
        {
            //var query = _userManager.Users;
            //var users = _context.Users.Join(_context.UserRoles, user => user.Id, userRole => userRole.UserId, (user, userRole) => new
            //{
            //    user,
            //    userRole
            //}).Select(x => new AppUser()
            //{
            //    Id = x.user.Id,
            //    AccessFailedCount = x.user.AccessFailedCount,
            //    ConcurrencyStamp = x.user.ConcurrencyStamp,
            //    Email = x.user.Email,
            //    EmailConfirmed = x.user.EmailConfirmed,
            //    LockoutEnabled = x.user.LockoutEnabled,
            //    LockoutEnd = x.user.LockoutEnd,
            //    NormalizedEmail = x.user.NormalizedEmail,
            //    NormalizedUserName = x.user.NormalizedUserName,
            //    PasswordHash = x.user.PasswordHash,
            //    PhoneNumber = x.user.PhoneNumber,
            //    PhoneNumberConfirmed = x.user.PhoneNumberConfirmed,
            //    Name = x.user.Name,
            //    SecurityStamp = x.user.SecurityStamp,
            //    Surname = x.user.Surname,
            //    TwoFactorEnabled = x.user.TwoFactorEnabled,
            //    UserName = x.user.UserName,
            //    Forms = x.user.Forms,

            //}).ToList();
            var users2 = await _userManager.GetUsersInRoleAsync("Member");
            return View(users2);
        }
       
    }
}
