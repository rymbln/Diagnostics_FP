using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Diagnostics_FP.Models;

namespace Diagnostics_FP.Controllers
{
    public class AccountController : Controller
    {

        [Authorize] public ViewResult Index()
        {
            ViewBag.Message = "Список зарегистрированных пользователей";
            MembershipUserCollection users = Membership.GetAllUsers();

            return View(users);
        }

        //
        // GET: /Account/LogOn

        public ActionResult LogOn()
        {
            return View();
        }

        //
        // POST: /Account/LogOn

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/LogOff

        [Authorize] public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/Register

        [Authorize] public ActionResult Register()
        {
            var roleList = System.Web.Security.Roles.GetAllRoles();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var obj in roleList)
            {
                items.Add(new SelectListItem {Text= obj.ToString(), Value = obj.ToString()});
                            
            }
            ViewBag.roleList = items;
            
                //var arrey = db.Employee.Where(x => x.Store_Id == id);
                //List<SelectListItem> items = new List<SelectListItem>();
                //foreach (var s in arrey)
                //{
                //    items.Add(new SelectListItem
                //    {
                //        Text = s.Name,
                //        Value = s.Id.ToString()
                //    });
                //}
                //ViewBag.Datas = items;

            return View();
        }

        //
        // POST: /Account/Register

        [HttpPost]
        [Authorize] public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                MembershipCreateStatus createStatus;
                Membership.CreateUser(model.UserName, model.Password, model.Email, null, null, true, null, out createStatus);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    Roles.AddUserToRole(model.UserName, model.Role);
                  //  FormsAuthentication.SetAuthCookie(model.UserName, false /* createPersistentCookie */);
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    ModelState.AddModelError("", ErrorCodeToString(createStatus));
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
        //
        //GET: /Account/Edit
        // 
        [Authorize]
        [Authorize] public ActionResult ChangeRoles(string userName)
        {
            EditUserModel obj = new EditUserModel();
            MembershipUser user = Membership.GetUser(userName);
            obj.UserName = user.UserName;
            
            obj.Email = user.Email;
            obj.Role = Roles.GetRolesForUser(user.UserName);
            var roleList = System.Web.Security.Roles.GetAllRoles();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var role in roleList)
            {
                if (Roles.IsUserInRole(user.UserName, role.ToString()))
                {
                    items.Add(new SelectListItem { Text = role.ToString(), Value = role.ToString(), Selected = true });
                }
                else
                {
                    items.Add(new SelectListItem { Text = role.ToString(), Value = role.ToString(), Selected = false  });
                }
            }
            ViewBag.roleItems = items;
            return View(obj);
        }

        //
        //POST: /Account/ChangeRoles
        //
        [Authorize]
        [HttpPost]
        [Authorize] public ActionResult ChangeRoles(EditUserModel model, string[] selectedRoles)
        {
            string[] roleList = System.Web.Security.Roles.GetAllRoles();
            foreach (var role in roleList)
            {
                if (Roles.IsUserInRole(model.UserName, role))
                {
                    Roles.RemoveUserFromRole(model.UserName, role);
                }
            }
            if (selectedRoles != null)
            {
                Roles.AddUserToRoles(model.UserName, selectedRoles);
            }
            return RedirectToAction("Index");
        }
        
        //
        //get: /Account/CreateRole
        //
        [Authorize]
        [Authorize] public ActionResult CreateRole()
        {
            return View();
        }

        //
        // POST: /Account/CreateRole
        //

        [Authorize]
        [Authorize] public ActionResult CreateRole(string roleName)
        {

            return RedirectToAction("Index", "Account");
        }


        [Authorize] public ActionResult Delete(string userName)
        {
                Membership.DeleteUser(userName);
            return RedirectToAction("Index");
        }

        //
        // GET: /Account/ChangePassword

        [Authorize]
        [Authorize] public ActionResult ChangePassword(string userName)
        {
            ViewBag.UserName = userName;
            return View();
        }

        //
        // POST: /Account/ChangePassword

        [Authorize]
        [HttpPost]
        [Authorize] public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {

                // ChangePassword will throw an exception rather
                // than return false in certain failure scenarios.
                bool changePasswordSucceeded;
                try
                {
                    MembershipUser currentUser = Membership.GetUser(User.Identity.Name, true /* userIsOnline */);
                    changePasswordSucceeded = currentUser.ChangePassword(model.OldPassword, model.NewPassword);
                }
                catch (Exception)
                {
                    changePasswordSucceeded = false;
                }

                if (changePasswordSucceeded)
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePasswordSuccess

        [Authorize] public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

        #region Status Codes
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }
}
