using monsterhunterAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Data
{
    public class DbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {


            context.Armors.Add(new Armor
            {
                Name = "Bob"
            });

            context.SaveChanges();
        }
    }
}