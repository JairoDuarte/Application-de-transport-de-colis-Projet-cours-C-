
using AutoMapper;
using ClassLibrary;
using System.Collections.Generic;
using System.Web.Mvc;
using AppWeb.ViewModels;

namespace AppWeb.Controllers
{

    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        UserRepository _user = new UserRepository();
        RoleRepository rl = new RoleRepository();
        UserRolesRepository ur = new UserRolesRepository();
        // GET: User
        public ActionResult Index()
        {
            var us = _user.list(); 
                return View(us);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult CreateUserRoles()
        {
            ViewBag.Roleid = new SelectList(rl.list(), "Id", "Nom");
            ViewBag.UserId = new SelectList(_user.list(), "Userid", "nomUser");

            return View();
        }

        [HttpPost]
        public ActionResult CreateUserRoles(UserRoleViewModels us)
        {
            if (ModelState.IsValid)
            {
                ur.add(us.UserId, us.Roleid);
                return RedirectToAction("index");
            }
            ViewBag.Roleid = new SelectList(rl.list(), "Id", "Nom");
            ViewBag.UserId = new SelectList(_user.list(), "Userid", "nomUser");

            return View();
        }
        public ActionResult DeleteUserRoles(string id1,string id2)
        {
             ur.delete(id1, id2);

            return RedirectToAction("index");
        }
        public ActionResult RolesUser(string id)
        {
          UserViewModel us =   _user.findroles(id);
            
            ViewBag.user = us;
            return View(us.Roles);
        }

        // GET: User/Edit/5
        public ActionResult Edit(string id)
        {
            UserViewModel u = _user.findid(id);
            return View(u);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(UserViewModel us)
        {
            
                if (ModelState.IsValid)
                {
                    _user.update(us);

                    return RedirectToAction("Index");
                }
          
                return View("index");
        }

        // GET: User/Delete/5
        public ActionResult Delete(string id)
        {
            UserViewModel us = _user.findid(id);
            return View(us);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, UserViewModel collection)
        {
            try
            {
                _user.delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
