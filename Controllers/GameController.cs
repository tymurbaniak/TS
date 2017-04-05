using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace TS.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        [Authorize]
        public ActionResult Index()
        {
            var user = User.Identity;
            
            var userName = user.GetUserName();

            return View(user);
        }
    }
}