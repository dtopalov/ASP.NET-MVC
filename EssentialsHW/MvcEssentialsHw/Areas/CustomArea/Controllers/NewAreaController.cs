using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEssentialsHw.Areas.CustomArea.Controllers
{
    public class NewAreaController : Controller
    {
        // GET: CustomArea/NewArea
        public ActionResult Index()
        {
            return this.View();
        }
    }
}