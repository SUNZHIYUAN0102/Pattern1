using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pattern1.Data;
using Pattern1.Models;
using Pattern1.Models.ViewModels;
using Pattern1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pattern1.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext1 context1;
        private readonly ApplicationDbContext2 context2;
        private readonly ApplicationDbContext3 context3;
        private readonly ILookUpService lookUpService;

        public AccountController(ApplicationDbContext1 context1, ApplicationDbContext2 context2, ApplicationDbContext3 context3, ILookUpService lookUpService)
        {
            this.context1 = context1;
            this.context2 = context2;
            this.context3 = context3;
            this.lookUpService = lookUpService;
        }
        public IActionResult Index()
        {
            ViewBag.User1 = context1.Users;
            ViewBag.User2 = context2.Users;
            return View();
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var id = context1.Users.Count() + context2.Users.Count() + 1;
 
                var user = new User
                {
                    Id = id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Password = model.Password
                };

                var shard = lookUpService.GetShard(id);

                if(shard == 1)
                {
                    this.context1.Add(user);
                    await this.context1.SaveChangesAsync();
                    return RedirectToAction(nameof(Register));
                }
                else
                {
                    this.context2.Add(user);
                    await this.context2.SaveChangesAsync();
                    return RedirectToAction(nameof(Register));
                }

            }

            return this.View(model);
        }
    }
}
