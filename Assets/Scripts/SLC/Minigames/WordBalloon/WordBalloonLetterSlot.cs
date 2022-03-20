using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordBalloonLetterSlot : MonoBehaviour
    {
        // Fields
        private int <Uid>k__BackingField;
        private int columnId;
        private int rowId;
        public SLC.Minigames.WordBalloon.LetterSlotLink SlotLink;
        private SLC.Minigames.WordBalloon.WordBalloonLetterTile letterTile;
        
        // Properties
        public int Uid { get; set; }
        public int ColumnId { get; }
        public int RowId { get; set; }
        public SLC.Minigames.WordBalloon.WordBalloonLetterTile LetterTile { get; }
        public bool HasLetterTile { get; }
        
        // Methods
        public int get_Uid()
        {
            return (int)this.<Uid>k__BackingField;
        }
        private void set_Uid(int value)
        {
            this.<Uid>k__BackingField = value;
        }
        public int get_ColumnId()
        {
            return (int)this.columnId;
        }
        public int get_RowId()
        {
            return (int)this.rowId;
        }
        public void set_RowId(int value)
        {
            this.rowId = value;
        }
        public SLC.Minigames.WordBalloon.WordBalloonLetterTile get_LetterTile()
        {
        
        }
        public bool get_HasLetterTile()
        {
            return UnityEngine.Object.op_Inequality(x:  this.letterTile, y:  0);
        }
        public void Initialize(int uId, int _colId, int _rowId)
        {
        
        }
        public void SetTile(SLC.Minigames.WordBalloon.WordBalloonLetterTile tileToBindTo)
        {
            this.letterTile = tileToBindTo;
        }
        public void SetLinksToNeighborSlots(SLC.Minigames.WordBalloon.LetterSlotLink link)
        {
        
        }
        public WordBalloonLetterSlot()
        {
        
        }
    
    }

}
