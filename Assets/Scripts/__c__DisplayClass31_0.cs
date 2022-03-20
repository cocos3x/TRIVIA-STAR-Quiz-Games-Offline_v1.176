using UnityEngine;
private sealed class GamePlay.<>c__DisplayClass31_0
{
    // Fields
    public BlockPuzzleMagic.Goal currentGoal;
    
    // Methods
    public GamePlay.<>c__DisplayClass31_0()
    {
    
    }
    internal bool <UpdateGoalProgress>b__2(BlockPuzzleMagic.GridCell obj)
    {
        var val_4 = 0;
        if(obj.isFilled == false)
        {
                return (bool)val_4;
        }
        
        BlockPuzzleMagic.BlockColorType val_2 = obj.<ChildBlock>k__BackingField.fillColorType;
        val_4 = 1;
        if((obj.<ChildBlock>k__BackingField) == this.currentGoal.goalColorValue)
        {
                return (bool)val_4;
        }
        
        BlockPuzzleMagic.Block val_4 = obj.<ChildBlock>k__BackingField;
        BlockPuzzleMagic.BlockColorType val_3 = val_4.fillColorType;
        val_4 = val_4 - 1;
        val_4 = val_4 >> 5;
        return (bool)val_4;
    }

}
