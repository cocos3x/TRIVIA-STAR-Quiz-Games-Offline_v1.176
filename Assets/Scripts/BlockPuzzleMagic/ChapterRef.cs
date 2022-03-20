using UnityEngine;

namespace BlockPuzzleMagic
{
    public class ChapterRef
    {
        // Fields
        public int chapterId;
        public System.Collections.Generic.List<BlockPuzzleMagic.LevelRef> levels;
        
        // Properties
        public BlockPuzzleMagic.LevelRef FirstLevel { get; }
        public BlockPuzzleMagic.LevelRef LastLevel { get; }
        
        // Methods
        public BlockPuzzleMagic.LevelRef get_FirstLevel()
        {
            if(true != 0)
            {
                    return;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        public BlockPuzzleMagic.LevelRef get_LastLevel()
        {
            var val_1;
            var val_2;
            if(this.levels != 0)
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
        }
        public static BlockPuzzleMagic.ChapterRef Parse(string _jsonString)
        {
            object val_1 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  _jsonString);
            _jsonString.Sort();
        }
        public void Sort()
        {
            var val_2;
            System.Comparison<BlockPuzzleMagic.LevelRef> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = ChapterRef.<>c.<>9__7_0;
            if(val_4 == 0)
            {
                    val_4 = null;
                val_4 = new System.Comparison<WordForest.NewsArticle>(object:  ChapterRef.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1273794768));
                ChapterRef.<>c.<>9__7_0 = val_4;
            }
            
            this.levels.Sort(comparison:  7933952);
        }
        public ChapterRef()
        {
        
        }
    
    }

}
