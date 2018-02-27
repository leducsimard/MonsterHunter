using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Models.ItemProperty
{
    public class Sharpness
    {
        public int Id { get; set; }

        public int RedSharpness { get; set; }

        public int orangeSharpness { get; set; }

        public int YellowSharpness { get; set; }

        public int GreenSharpness { get; set; }

        public int BlueSharpness { get; set; }

        public int WhiteSharpness { get; set; }

        public virtual Weapon Weapon { get; set; }
    }
}