using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GoalRef
    {
        // Fields
        public BlockPuzzleMagic.Goal.GoalType goalType;
        public int targetValue;
        
        // Methods
        public GoalRef(BlockPuzzleMagic.Goal.GoalType _goalType, int _goalAmt)
        {
            this.goalType = _goalType;
            this.targetValue = _goalAmt;
        }
    
    }

}
