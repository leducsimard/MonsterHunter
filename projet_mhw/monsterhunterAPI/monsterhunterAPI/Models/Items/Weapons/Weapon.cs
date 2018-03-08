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
        public string Rarity { get; set; }
        public int Attack { get; set; }
        public virtual DecorationSlotTable DecorationSlotTable { get; set; }
    }
}