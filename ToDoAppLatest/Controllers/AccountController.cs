using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ToDoAppLatest.Data;
using ToDoAppLatest.Models;
using ToDoAppLatest.Models.ViewModel;
using ToDoAppLatest.Migrations;
using System.Collections.Generic;
using System.Linq;

namespace ToDoAppLatest.Controllers
{
    public class AccountController : Controller
    { 
    
    private readonly ApplicationDbContext dbcontext;

    public AccountController(ApplicationDbContext dbcontext)

    {
        this.dbcontext = dbcontext;

    }
    
        public IActionResult Index()
        {
            Users obj = new Users();
            return View(obj);

        }
        public IActionResult UserRegister()
        {
            
            return View();
              
        }
        [HttpPost]
        public IActionResult Index( Users objuser)
        {
            UserDetails dtl = new UserDetails();
            List<UserDetails> li = new List<UserDetails>();
             foreach (var item in dbcontext.UserDetails.ToList())
            {

                li.Add(new UserDetails
                {
                    UserId = item.UserId,
                    Email = item.Email,
                    Password = item.Password,
                    UserName = item.UserName,
                });
                }
            if (dtl != null)
            {
                var claim = new[]
                {
                    new Claim("UserId",dtl.UserId.ToString())
                };
                var identity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
                var principle = new ClaimsPrincipal(identity);
                var authProperty = new AuthenticationProperties
                {
                    ExpiresUtc = DateTime.Now.AddMinutes(2)
                };
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle, authProperty);
                if(ModelState.IsValid)
                {
                    var obj=dbcontext.UserDetails.Where(a=>a.UserName.Equals(objuser.User_Name)&&a.Password.Equals(objuser.Password)).FirstOrDefault();
                    Login login = new Login();
                   
                    var date = DateTime.Now;
                    
                    if (obj != null)
                    {

                        login.User_Id = obj.UserId.ToString();
                         login.Login_Time = date;
                         login.Status = " Active";
                            
                            dbcontext.Logins.Add(login);
                            dbcontext.SaveChanges();
                            return Redirect("~/ToDo/Index");
                     }
                    
                    else 
                    {
                       
                        return RedirectToAction("Index");


                    }
                }
            }
            
            return View(objuser);


        }
        [HttpPost]
        public IActionResult UserRegister(UserDetails user)
        {
            dbcontext.UserDetails.Add(user);
            dbcontext.SaveChanges();
            ViewBag.message = "The user " + user.UserName + " is saved successfully";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }
}
