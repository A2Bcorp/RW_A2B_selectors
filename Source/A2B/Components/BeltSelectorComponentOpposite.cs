using System;
using RimWorld;
using Verse;
using A2B;

namespace A2B_Selector
{
    
	public class Opposite : BeltSelectorAddon
    {
        
        public override void GetIOVectors()
        {
            inputVectors = new Rot4[]{ Rot4.South, Rot4.North };
            outputOneVectors = new Rot4[]{ Rot4.West };
            outputTwoVectors = new Rot4[]{ Rot4.East };
        }

    }
}