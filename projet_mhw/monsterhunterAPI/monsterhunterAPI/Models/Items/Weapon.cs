using monsterhunterAPI.Models.ItemProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Sharpness Sharpness { get; set; }
        public virtual WeaponType WeaponType { get; set; }
        public virtual DecorationSlotTable DecorationSlotTable { get; set; }
    }
}