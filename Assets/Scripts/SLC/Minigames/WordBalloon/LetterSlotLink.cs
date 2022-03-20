using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    [Serializable]
    public struct LetterSlotLink
    {
        // Fields
        public SLC.Minigames.WordBalloon.WordBalloonLetterSlot left;
        public SLC.Minigames.WordBalloon.WordBalloonLetterSlot right;
        public SLC.Minigames.WordBalloon.WordBalloonLetterSlot above;
        public SLC.Minigames.WordBalloon.WordBalloonLetterSlot below;
        
        // Methods
        public SLC.Minigames.WordBalloon.WordBalloonLetterSlot GetLinkedSlot(SLC.Minigames.WordBalloon.SlotDirection direction)
        {
            var val_2;
            direction = direction - 1;
            if(direction > 3)
            {
                    this = 0;
                return;
            }
            
            var val_1 = 13292668 + (13292668 + ((direction - 1)) << 2);
            if(direction == 3)
            {
                    this = this & ((R4) >> 32);
                this = this & (this << this);
                this = this & ((R8) << ((this & (R4) >> 32) & ((this & (R4) >> 32)) << (this & (R4) >> 32)));
                this = this & (this >> 32);
            }
            
            val_2 = this + 4;
        }
    
    }

}
