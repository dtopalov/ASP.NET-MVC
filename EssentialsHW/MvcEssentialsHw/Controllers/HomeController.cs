namespace MvcEssentialsHw.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    using MvcEssentialsHw.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}