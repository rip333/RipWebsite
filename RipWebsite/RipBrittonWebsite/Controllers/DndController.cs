using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
using PokefamCore.Factory.Pokefams;
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

        public ActionResult Rules()
        {
            return View();
        }

        [Route("/Dnd/Pokefam")]
        public ActionResult Pokefam()
        {
            var pokefamList = PokeFactory.GetAll;
            return View(pokefamList);
        }

        [Route("/Dnd/Pokefam/{id}")]
        public ActionResult GetPokefam(int id)
        {
            var pokefamList = PokeFactory.GetAll;
            return View(pokefamList.First(x => x.Id == id));
        }

        [Route("/Dnd/Pokefam/game")]
        public ActionResult PokefamGame()
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