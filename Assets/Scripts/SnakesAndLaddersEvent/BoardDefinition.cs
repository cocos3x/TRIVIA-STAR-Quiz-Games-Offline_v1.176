using UnityEngine;

namespace SnakesAndLaddersEvent
{
    public class BoardDefinition
    {
        // Fields
        public const int COLS_PER_ROW = 6;
        public int MaxSpaceCount;
        public System.Collections.Generic.List<SnakesAndLaddersEvent.BoardSpace> BoardSpaces;
        
        // Methods
        public BoardDefinition(int maxBoardSpaces, System.Collections.Generic.List<int> rewardSpaceIndices, System.Collections.Generic.List<SnakesAndLaddersEvent.NumberSpaceConnectionDefinition> numberSpaceConnections)
        {
            SnakesAndLaddersEvent.BoardDefinition val_4;
            var val_5;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_4 = this;
            val_5 = val_1;
            val_1 = new System.Object();
            val_6 = null;
            val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(maxBoardSpaces >= 1)
            {
                    var val_8 = 1;
                val_7 = 0;
                do
            {
                val_8 = 0;
                val_9 = 0;
                if(val_7 < maxBoardSpaces)
            {
                    if(maxBoardSpaces <= val_7)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + 0;
                if(val_8 == ((0 + 0) + 16 + 8))
            {
                    if(((0 + 0) + 16 + 8) <= val_7)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + 0;
                val_8 = mem[(0 + 0) + 16 + 12];
                val_8 = (0 + 0) + 16 + 12;
                val_7 = val_7 + 1;
            }
            
                val_9 = 0;
            }
            
                val_10 = 0;
                if(0 < maxBoardSpaces)
            {
                    if(maxBoardSpaces <= 0)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = val_6 + 0;
                var val_7 = (0 + 0) + 16;
                val_7 = val_8 - val_7;
                if(val_8 == val_7)
            {
                    val_9 = val_9 + 1;
            }
            
                val_10 = val_7 >> 5;
            }
            
                object val_3 = null;
                val_4 = val_3;
                val_3 = new System.Object();
                typeof(SnakesAndLaddersEvent.BoardSpace).__il2cppRuntimeField_8 = val_8;
                typeof(SnakesAndLaddersEvent.BoardSpace).__il2cppRuntimeField_C = val_8;
                val_6 = val_6;
                typeof(SnakesAndLaddersEvent.BoardSpace).__il2cppRuntimeField_10 = val_10;
                Add(item:  432373760);
                val_8 = val_8 + 1;
                val_5 = val_5;
            }
            while(val_8 <= maxBoardSpaces);
            
            }
            
            mem[1152921513875950520] = maxBoardSpaces;
            mem[1152921513875950524] = val_6;
        }
        public int GetRows()
        {
            int val_1 = this.MaxSpaceCount;
            val_1 = val_1 + (val_1 >> 31);
            return (int)val_1;
        }
        public bool Equals(SnakesAndLaddersEvent.BoardDefinition anotherBoard)
        {
            int val_1 = anotherBoard.MaxSpaceCount;
            val_1 = this.MaxSpaceCount - val_1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
    
    }

}
