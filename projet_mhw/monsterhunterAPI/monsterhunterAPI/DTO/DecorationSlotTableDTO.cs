using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.DTO
{
    public class DecorationSlotTableDTO
    {
        public string Name { get; set; }
    }

    public class DecorationSlotTableCreationDTO
    {
        public int decoration_1_level { get; set; }
        public int decoration_2_level { get; set; }
        public int decoration_3_level { get; set; }
    }
}