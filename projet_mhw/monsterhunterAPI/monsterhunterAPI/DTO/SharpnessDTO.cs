using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.DTO
{
    public class SharpnessDTO
    {
        public string Name { get; set; }
    }

    public class SharpnessCreationDTO
    {
        public int RedSharpness { get; set; }
        public int OrangeSharpness { get; set; }
        public int YellowSharpness { get; set; }
        public int GreenSharpness { get; set; }
        public int BlueSharpness { get; set; }
        public int WhiteSharpness { get; set; }
    }
}