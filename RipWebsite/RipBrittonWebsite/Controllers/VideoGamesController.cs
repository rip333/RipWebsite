using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RipBrittonWebsite.Controllers
{
    public class VideoGamesController : Controller
    {
        // GET: VideoGames
        public ActionResult Index()
        {
            return View();
        }
    }
}