using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Models.ItemProperty
{
    public class DecorationSlotTable
    {
        public int Id { get; set; }
        public virtual DecorationSlot DecorationSlot1 { get; set; }
        public virtual DecorationSlot DecorationSlot2 { get; set; }
        public virtual DecorationSlot DecorationSlot3 { get; set; }
    }
}