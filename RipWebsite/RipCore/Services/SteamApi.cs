using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortableSteam;
using PortableSteam.Interfaces.Game.Dota2.IDOTA2;

namespace RipCore.Services
{
    public class SteamApi
    {
        private string _key;
        private static int DOTA_APP_ID = 570;

        public SteamApi(string key)
        {
            _key = key;
        }
    }
}
