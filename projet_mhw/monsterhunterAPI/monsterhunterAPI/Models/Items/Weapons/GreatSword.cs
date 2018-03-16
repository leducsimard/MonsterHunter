using monsterhunterAPI.Models.ItemProperty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Models.Items.Weapons
{
    public class GreatSword : Weapon
    {
        public Element Element { get; set; }
        public Sharpness Sharpness { get; set; }
        [DefaultValue(0)]
        public int Affinity { get; set; }
        [DefaultValue(0)]
        public int Defense { get; set; }
    }
}