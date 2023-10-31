using _1670Project.Models.Form;
using _1670Project.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace _1670Project.Controllers
{
    public class UserControler : Controller
    {
        private IUserAuthenticationService userAuthenticationService;
        public UserControler(IUserAuthenticationService userAuthenticationService)
        {
            this.userAuthenticationService = userAuthenticationService;
        }
        //create user 

        public async Task<IActionResult> Register()
        {
            var model = new RegistrationModel
            {
                Email = "admin@gmail.com",
                Username = "admin@gmail.com",
                Name = "Flowerf",
                Password = "P@ssW0rd",
                PasswordConfirm = "P@ssW0rd",
                Role = "Admin"
            };

            var result = await userAuthenticationService.RegisterAsync(model);
            return Ok(result.Message);
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await userAuthenticationService.LoginAsync(model);
            if (result.StatusCode == 1)
                return RedirectToAction("Index", "Books");
            else
            {
                TempData["msg"] = "Could not logged in..";
                return RedirectToAction(nameof(Login));
            }
        }

        public async Task<IActionResult> Logout(LoginModel model)
        {
            await userAuthenticationService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}
