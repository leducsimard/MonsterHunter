using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Models.ItemProperty
{
    public class Element
    {
        public int Id { get; set; }
        public int Attack { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}