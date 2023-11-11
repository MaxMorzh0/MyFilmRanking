using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string returnUrl = "/")
    {
        var isValidUser = CheckCredentials("user1@gmail.com", "pass121");

        if (isValidUser)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "user1@gmail.com"),
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return LocalRedirect(returnUrl);
        }
        else
            return RedirectToAction("Main", "Home");
    }

    public IActionResult Logout()
    {
        HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Main", "Home");
    }

    private bool CheckCredentials(string email, string password)
    {
        return email == "user1@gmail.com" && password == "pass121";
    }
}

