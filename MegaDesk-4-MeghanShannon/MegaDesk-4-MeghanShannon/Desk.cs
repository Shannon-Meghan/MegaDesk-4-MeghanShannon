using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_MeghanShannon
{
    class Desk
    {
        /*
         * This class will define the attributes of the desk object with width, depth, 
         * number of drawers, and the surface material may contain validation of those attribute values.
         */
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        //public string DesktopMaterial { get; set; }
        
        public Material DesktopMaterial { get; set; }
        // Desk Constraints/Constants
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
    }

    public enum Material
    {
        Laminate = 100,
        Oak = 200,
        Pine = 50,
        Veneer = 150,
        Rosewood = 300
    }
}
