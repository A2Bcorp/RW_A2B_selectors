using System;
using RimWorld;
using Verse;
using A2B;

namespace A2B_Selector
{
    
	public class Right_Soft : Soft
    {

        public override void GetIOVectors()
        {
            inputVectors = new Rot4[]{ Rot4.South };
            outputOneVectors = new Rot4[]{ Rot4.East };
            outputTwoVectors = new Rot4[]{ Rot4.West, Rot4.North };
        }

    }
}