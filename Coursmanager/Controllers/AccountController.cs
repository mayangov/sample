﻿using Coursmanager.Models;
using Coursmanager.Models.ValidatableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coursmanager.Controllers
{

    public class AccountController : Controller
    {
        private CourseManagerContext db = new CourseManagerContext();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginInput input)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.FirstOrDefault(u => u.Account == input.Account && u.Password == input.Password);
                if(user == null)
                {
                    ModelState.AddModelError("Password", "用户名不存在或密码输入错误");
                    return View(input);
                }
                HttpContext.Session?.Add("user", user);
                var cookie = new HttpCookie("user", user.Account)
                {
                    Expires = DateTime.Now.AddHours(3)
                };
                return RedirectToAction("Index","Home");
            }

            return View(input);
        }
    }
}