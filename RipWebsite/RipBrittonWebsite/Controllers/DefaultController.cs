using RipCore.Services;
using System.Web.Mvc;

namespace RipBrittonWebsite.Controllers
{
    public class DefaultController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            var openDotaApi = new OpenDotaApi(System.Configuration.ConfigurationManager.AppSettings.Get("DotaId"));
            return View();
        }

        [Route("Error")]
        public string Error()
        {
            return "Error";
        }
    }
}