using UnityEngine;

namespace BlockPuzzleMagic
{
    public class Goal
    {
        // Fields
        public BlockPuzzleMagic.Goal.GoalType goalType;
        public int targetValue;
        public int currentValue;
        public BlockPuzzleMagic.BlockColorType goalColorValue;
        
        // Methods
        public Goal(BlockPuzzleMagic.Goal.GoalType _goalType, int _goalAmt, BlockPuzzleMagic.BlockColorType _colorType = 0)
        {
            this.goalType = _goalType;
            this.targetValue = _goalAmt;
            this.currentValue = 0;
            this.goalColorValue = _colorType;
        }
        public static bool IsUnlocked(BlockPuzzleMagic.Goal.GoalType gType)
        {
            return true;
        }
        public static bool IsGoalGridObjective(BlockPuzzleMagic.Goal.GoalType gType)
        {
            if(gType == 4)
            {
                    gType = 1;
            }
            
            if(gType != 4)
            {
                    gType = -4;
            }
            
            if(gType != 4)
            {
                    gType = 0;
            }
            
            return (bool)gType;
        }
        public static bool IsGoalColorBased(BlockPuzzleMagic.Goal.GoalType goalType)
        {
            goalType = goalType - 3;
            goalType = goalType >> 5;
            return (bool)goalType;
        }
    
    }

}
