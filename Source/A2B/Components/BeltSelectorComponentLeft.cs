using System;
using RimWorld;
using Verse;
using A2B;

namespace A2B_Selector
{
    
	public class Left : BeltSelectorAddon
    {

        public override void GetIOVectors()
        {
            inputVectors = new Rot4[]{ Rot4.South };
            outputOneVectors = new Rot4[]{ Rot4.West };
            outputTwoVectors = new Rot4[]{ Rot4.North, Rot4.East };
        }

    }
}