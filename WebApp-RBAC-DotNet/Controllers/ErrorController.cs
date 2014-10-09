﻿using System.Web.Mvc;

namespace WebAppRBACDotNet.Controllers
{
    public class ErrorController : Controller
    {
        /// <summary>
        ///     Shows an on-screen error message when the user attemps various
        ///     illegal actions.
        /// </summary>
        /// <returns>Generic error <see cref="View" />.</returns>
        public ActionResult ShowError(string errorMessage, string signIn)
        {
            ViewBag.SignIn = signIn;
            ViewBag.ErrorMessage = errorMessage;
            return View();
        }
    }
}