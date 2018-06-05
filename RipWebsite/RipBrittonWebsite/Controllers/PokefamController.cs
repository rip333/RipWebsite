using PokefamCore.Factory.Pokefams;
using PokefamCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace RipBrittonWebsite.Controllers
{
    public class PokefamController : ApiController
    {
        public List<Pokefam> pokefamList = new List<Pokefam>();

        public PokefamController()
        {
            pokefamList = PokeFactory.GetAll;
        }

        // GET: api/Pokefam
        public string Get()
        {
            return JsonConvert.SerializeObject(pokefamList);
        }

        // GET: api/Pokefam/5
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(pokefamList.Where(x => x.Id == id));
        }

        // POST: api/Pokefam
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pokefam/5
        public void Put(int id, [FromBody]Pokefam pokefam)
        {
        }

        // DELETE: api/Pokefam/5
        public void Delete(int id)
        {
        }
    }
}
