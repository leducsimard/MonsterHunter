using monsterhunterAPI.Models.ItemProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Models.Items.Weapons
{
    public class GreatSword : Weapon
    {
        public Element Element { get; set; }
        public Sharpness Sharpness { get; set; }
    }
}