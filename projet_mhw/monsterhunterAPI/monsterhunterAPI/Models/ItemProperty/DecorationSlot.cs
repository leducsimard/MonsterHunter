using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Models.ItemProperty
{
    public class DecorationSlot
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public virtual DecorationSlotTable DecorationTable { get; set; }
    }
}