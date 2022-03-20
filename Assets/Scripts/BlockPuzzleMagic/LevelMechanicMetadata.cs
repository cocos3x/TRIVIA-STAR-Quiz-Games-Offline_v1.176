using UnityEngine;

namespace BlockPuzzleMagic
{
    public class LevelMechanicMetadata
    {
        // Fields
        public BlockPuzzleMagic.MechanicType mechanicType;
        public System.Collections.Generic.Dictionary<string, object> mechanicData;
        
        // Methods
        public T GetData<T>(string propertyName, T defaultVal)
        {
            var val_3;
            string val_4;
            val_3 = defaultVal;
            val_4 = propertyName;
            if((this.mechanicData.ContainsKey(key:  val_4)) == false)
            {
                    return;
            }
            
            object val_2 = this.mechanicData.Item[val_4];
            val_4 = this.mechanicData;
            val_3 = 0;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_3 = val_4;
            if(val_4 != 0)
            {
                    return;
            }
            
            val_3 = 0;
        }
        public static BlockPuzzleMagic.LevelMechanicMetadata Clone(BlockPuzzleMagic.LevelMechanicMetadata instance)
        {
            BlockPuzzleMagic.LevelMechanicMetadata val_1 = new BlockPuzzleMagic.LevelMechanicMetadata();
            typeof(BlockPuzzleMagic.LevelMechanicMetadata).__il2cppRuntimeField_8 = instance.mechanicType;
            System.Collections.Generic.Dictionary<System.String, System.Type> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  instance.mechanicData);
            typeof(BlockPuzzleMagic.LevelMechanicMetadata).__il2cppRuntimeField_C = null;
        }
        public LevelMechanicMetadata()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.mechanicData = null;
        }
    
    }

}
