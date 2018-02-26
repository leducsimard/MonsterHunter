using monsterhunterAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace monsterhunterAPI.Controllers
{
    [Authorize]
    public class ArmorsController : ApiController
    {
        private ArmorService armorService = new ArmorService();

        public string Get(int id)
        {
            return "pouet";
        }
    }
}
