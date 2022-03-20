using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordBalloonGridSurface
    {
        // Fields
        public int rowIndex;
        public SLC.Minigames.WordBalloon.WordBalloonGridSurface.OrientationType orientation;
        public System.Collections.Generic.List<int> columnIndexes;
        private int <Height>k__BackingField;
        
        // Properties
        public int FirstColumnIndex { get; }
        public int LastColumnIndex { get; }
        public int Width { get; }
        public int Height { get; set; }
        
        // Methods
        public int get_FirstColumnIndex()
        {
            if(true != 0)
            {
                    return 2621443;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return 2621443;
        }
        public int get_LastColumnIndex()
        {
            var val_1;
            var val_2;
            if(this.columnIndexes != 0)
            {
                    val_2 = true;
            }
            else
            {
                    val_2 = 0;
                val_1 = 0;
            }
            
            if(val_1 <= (-1))
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 4294967292;
            return (int)(0 + 4294967292) + 16;
        }
        public int get_Width()
        {
            if(this.columnIndexes != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public int get_Height()
        {
            return (int)this.<Height>k__BackingField;
        }
        public void set_Height(int value)
        {
            this.<Height>k__BackingField = value;
        }
        public WordBalloonGridSurface(SLC.Minigames.WordBalloon.WordBalloonGridSurface.OrientationType _orientationType, int row)
        {
            this.rowIndex = row;
            this.orientation = _orientationType;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            this.columnIndexes = null;
        }
        public int GetColumnIdBySurfaceIndex(int index)
        {
            if(true <= index)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 2);
            return (int)(0 + (index) << 2) + 16;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = "{ Row: ";
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = ", StartColumn: ";
            int val_1 = this.FirstColumnIndex;
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = ", EndColumn: ";
            int val_2 = this.LastColumnIndex;
            typeof(System.Object[]).__il2cppRuntimeField_24 = null;
            typeof(System.Object[]).__il2cppRuntimeField_28 = ", Width: ";
            int val_3 = this.Width;
            typeof(System.Object[]).__il2cppRuntimeField_2C = null;
            typeof(System.Object[]).__il2cppRuntimeField_30 = ", Height: ";
            typeof(System.Object[]).__il2cppRuntimeField_34 = null;
            typeof(System.Object[]).__il2cppRuntimeField_38 = " }";
            string val_4 = +472754880;
        }
    
    }

}
