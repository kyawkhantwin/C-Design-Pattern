using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Strategy.GoodSolution.Overlay
{
    public class OverlayNone : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Not Applying overlay");
        }
    }
}