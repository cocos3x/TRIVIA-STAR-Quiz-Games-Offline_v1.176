using UnityEngine;
public class WGSnakesAndLaddersBoardPopupHeader : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<WGSnakesAndLaddersBoardProgressUI> progress;
    
    // Methods
    public void Setup(System.Collections.Generic.List<SnakesAndLaddersEvent.Board> boards)
    {
        var val_6;
        var val_6 = 28584032;
        val_6 = 7041760 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = 0;
        int val_1 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetCurrentBoardIndex();
        goto label_3;
        label_10:
        if(val_1 <= val_6)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + 0;
        if(0 <= val_6)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + 0;
        float val_2 = (0 + 0) + 16.GetPercentProgress();
        val_6 = 1;
        (0 + 0) + 16.Setup(boardNum:  1, isCurrentBoard:  (val_1 - val_6) >> 5, percentProgress:  ((0 + 0) + 16) * 100f);
        label_3:
        if(val_6 < ((0 + 0) + 16))
        {
            goto label_10;
        }
    
    }
    public WGSnakesAndLaddersBoardPopupHeader()
    {
    
    }

}
