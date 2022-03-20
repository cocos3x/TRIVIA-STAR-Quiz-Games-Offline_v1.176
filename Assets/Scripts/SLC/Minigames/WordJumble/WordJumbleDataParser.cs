using UnityEngine;

namespace SLC.Minigames.WordJumble
{
    public class WordJumbleDataParser : MonoSingleton<SLC.Minigames.WordJumble.WordJumbleDataParser>
    {
        // Fields
        private UnityEngine.TextAsset wordData;
        private System.Collections.Generic.Dictionary<string, object> availableData;
        private System.Collections.Generic.List<string> usedKeys;
        private System.Collections.Generic.List<string> availableKeys;
        private int maxWithoutRepeat;
        private UnityEngine.TextAsset perLevelDataFile;
        private System.Collections.Generic.Dictionary<string, object> levelData;
        
        // Methods
        public override void InitMonoSingleton()
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_8;
            string val_1 = this.wordData.text;
            object val_2 = MiniJSON.Json.Deserialize(json:  this.wordData);
            val_7 = 1152921504685600768;
            this.availableData = 0;
            Dictionary.KeyCollection<TKey, TValue> val_3 = 0.Keys;
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Object>(source:  0);
            this.availableKeys = 0;
            val_8 = 0;
            string val_5 = this.perLevelDataFile.text;
            object val_6 = MiniJSON.Json.Deserialize(json:  this.perLevelDataFile);
            if(this.perLevelDataFile != 0)
            {
                    if(((UnityEngine.TextAsset.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    this.perLevelDataFile = 0;
            }
            
                val_8 = this.perLevelDataFile;
            }
            
            this.levelData = val_8;
        }
        public SLC.Minigames.WordJumble.WordJumbleLevel getLevel(int currentLevel)
        {
            var val_9;
            var val_10;
            var val_11;
            if((currentLevel + 24) != 0)
            {
                    val_9 = currentLevel + 24;
                val_10 = UnityEngine.Random.Range(min:  0, max:  currentLevel + 24 + 12);
            }
            else
            {
                    val_9 = 12;
                val_10 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(val_9 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = currentLevel + 24 + 8;
            val_9 = val_9 + (val_10 << 2);
            string val_3 = currentLevel + 16.Item[(currentLevel + 24 + 8 + (val_2) << 2) + 16];
            val_11 = 0;
            if((currentLevel + 16) != 0)
            {
                    if(((currentLevel + 16 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    currentLevel + 16 = 0;
            }
            
                val_11 = currentLevel + 16;
            }
            
            currentLevel + 20.Add(item:  (currentLevel + 24 + 8 + (val_2) << 2) + 16);
            bool val_4 = currentLevel + 24.Remove(item:  (currentLevel + 24 + 8 + (val_2) << 2) + 16);
            if((currentLevel + 20 + 12) > (currentLevel + 28))
            {
                    if((currentLevel + 20 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                bool val_5 = currentLevel + 20.Remove(item:  currentLevel + 20 + 8 + 16);
                currentLevel + 24.Add(item:  currentLevel + 20 + 8 + 16);
            }
            
            string val_6 = ???.ToString();
            string val_7 = currentLevel + 36.Item[915751160];
            this = 0;
            mem[1152921514112544772] = 0;
            this = new SLC.Minigames.WordJumble.WordJumbleLevel(name:  (currentLevel + 24 + 8 + (val_2) << 2) + 16, data:  0, levelSpecData:  currentLevel + 36);
            return new SLC.Minigames.WordJumble.WordJumbleLevel() {<category>k__BackingField = this, <levelWords>k__BackingField = (currentLevel + 24 + 8 + (val_2) << 2) + 16};
        }
        public WordJumbleDataParser()
        {
            this.usedKeys = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.availableKeys = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.maxWithoutRepeat = 50;
        }
    
    }

}
