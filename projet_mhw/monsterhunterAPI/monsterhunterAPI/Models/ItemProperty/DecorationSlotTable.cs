using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Models.ItemProperty
{
    public class DecorationSlotTable
    {
        public int Id { get; set; }
        public virtual DecorationSlot DecorationSlot_1 { get; set; }
        public virtual DecorationSlot DecorationSlot_2 { get; set; }
        public virtual DecorationSlot DecorationSlot_3 { get; set; }
    }
}