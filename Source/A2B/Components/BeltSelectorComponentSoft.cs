using System;
using RimWorld;
using Verse;
using A2B;

namespace A2B_Selector
{
    
	public class Soft : BeltSelectorAddon
    {
        
        public override IntVec3 GetDestinationForThing(Thing thing)
        {
            // Test the 'selection' idea ...
            if( slotParent == null )
            {
                throw new InvalidOperationException("parent is not a SlotGroupParent!");
            }

            IntVec3 destination;

            // Matches filter?
            var selectionSettings = slotParent.GetStoreSettings();
            if( selectionSettings.AllowedToAccept( thing ) )
            {
                // Send it to the next "1" output
                destination = GetOutputVector( thing, outputOnePos, _lastOnePosition, allowOutputOneToGround );
                if( destination != IntVec3.Invalid )
                {
                    _lastOnePosition = destination;
                    return _lastOnePosition;
                }
            }

            // Doesn't match, send it to the next "2" output
            destination = GetOutputVector( thing, outputTwoPos, _lastTwoPosition, allowOutputTwoToGround );
            if( destination != IntVec3.Invalid )
                _lastTwoPosition = destination;
            return _lastTwoPosition;
        }

	}
}