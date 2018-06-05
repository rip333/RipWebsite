using System.Web.Mvc;
using Newtonsoft.Json;
using PokefamCore.Models;
using PokefamCore.Utility;

namespace RipBrittonWebsite.Controllers
{
    public class DndController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TypeChart()
        {
            return View();
        }

        public ActionResult AbilityTypes()
        {
            var typeChart = new TypeChart();
            return Json(typeChart.abilityTypes, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetModifier(string attackType, string defenderPrimaryType,
            string defenderSecondaryType = "Pure")
        {
            TypeChart typeChart = new TypeChart();
            var modifier = typeChart.GetModifier(attackType, defenderPrimaryType, defenderSecondaryType);
            return View(modifier);
        }
    }
}