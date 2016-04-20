using System;
using RimWorld;
using Verse;
using A2B;

namespace A2B_Selector
{
    
	public class Original_Left : BeltSelectorAddon
    {
        
        public override void GetIOVectors()
        {
            inputVectors = new Rot4[]{ Rot4.South, Rot4.East };
            outputOneVectors = new Rot4[]{ Rot4.West };
            outputTwoVectors = new Rot4[]{ Rot4.North };
        }

	}
}