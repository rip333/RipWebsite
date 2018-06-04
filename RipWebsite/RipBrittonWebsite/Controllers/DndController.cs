using System.Web.Mvc;
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

        public ActionResult GetModifier(TypeOf attackType, TypeOf defenderPrimaryType,
            TypeOf defenderSecondaryType = TypeOf.Pure)
        {
            TypeChart typeChart = new TypeChart();
            var modifier = typeChart.GetModifier(attackType, defenderPrimaryType, defenderSecondaryType);
            return View(modifier);
        }
    }
}