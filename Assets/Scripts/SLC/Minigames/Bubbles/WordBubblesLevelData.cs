using UnityEngine;

namespace SLC.Minigames.Bubbles
{
    public class WordBubblesLevelData
    {
        // Fields
        private int <LevelIndex>k__BackingField;
        private float <TimeLength>k__BackingField;
        private int <FragmentsCount>k__BackingField;
        
        // Properties
        public int LevelIndex { get; set; }
        public float TimeLength { get; set; }
        public int FragmentsCount { get; set; }
        
        // Methods
        public int get_LevelIndex()
        {
            return (int)this.<LevelIndex>k__BackingField;
        }
        private void set_LevelIndex(int value)
        {
            this.<LevelIndex>k__BackingField = value;
        }
        public float get_TimeLength()
        {
            return (float)S0;
        }
        private void set_TimeLength(float value)
        {
            this.<TimeLength>k__BackingField = ;
        }
        public int get_FragmentsCount()
        {
            return (int)this.<FragmentsCount>k__BackingField;
        }
        private void set_FragmentsCount(int value)
        {
            this.<FragmentsCount>k__BackingField = value;
        }
        public WordBubblesLevelData(int levelIndex, float timeLen, int fragCount)
        {
            this.<LevelIndex>k__BackingField = levelIndex;
            this.<TimeLength>k__BackingField = fragCount;
            this.<FragmentsCount>k__BackingField = R3;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = "Level:";
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = ", time:";
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = ", fragCount:";
            typeof(System.Object[]).__il2cppRuntimeField_24 = null;
            string val_1 = +472754880;
        }
    
    }

}
