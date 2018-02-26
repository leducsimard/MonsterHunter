using monsterhunterAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Services
{
    public class ArmorService
    {
        private ApplicationDbContext Context { get; }
            = ApplicationDbContext.Create();

        public ArmorService()
        {
        }
    }
}