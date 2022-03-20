using UnityEngine;

namespace WordForest
{
    public class WFOWordChestManager : MonoSingleton<WordForest.WFOWordChestManager>
    {
        // Fields
        public System.Action OnWordChestUpdated;
        
        // Properties
        public static bool IsFeatureUnlocked { get; }
        public bool IsChestReady { get; }
        public WordForest.WFOWordChestType CurrentWordChestType { get; }
        public int CurrentWordsRequired { get; }
        public int CurrentWordsCompleted { get; set; }
        public int LastForestChestCollectedPlayerLvel { get; set; }
        
        // Methods
        public static bool get_IsFeatureUnlocked()
        {
            return false;
        }
        public bool get_IsChestReady()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            if(R5 >= R1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public WordForest.WFOWordChestType get_CurrentWordChestType()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(this != 0)
            {
                    return;
            }
        
        }
        public int get_CurrentWordsRequired()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(this != 0)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        public int get_CurrentWordsCompleted()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(this != 0)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        protected void set_CurrentWordsCompleted(int value)
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            mem[1152921513550009876] = value;
        }
        public int get_LastForestChestCollectedPlayerLvel()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  353315984, defaultValue:  0);
        }
        private void set_LastForestChestCollectedPlayerLvel(int value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  353315984, value:  value);
        }
        public override void InitMonoSingleton()
        {
            this.Init();
        }
        private void InitNewRandomData()
        {
            int val_5;
            RandomSet val_1 = new RandomSet();
            WordForest.WFOGameEcon val_2 = WordForest.WFOGameEcon.Instance;
            Dictionary.Enumerator<TKey, TValue> val_3 = 0.GetEnumerator();
            label_5:
            if(0.MoveNext() == false)
            {
                goto label_3;
            }
            
            add(item:  val_5, weight:  0f);
            goto label_5;
            label_3:
            0.Dispose();
            int val_6 = roll(unweighted:  false);
            val_6.InitNewData(chestType:  val_6);
        }
        private void InitNewData(WordForest.WFOWordChestType chestType)
        {
            bool val_4 = static_value_021FA63E;
            if(val_4 != true)
            {
                    val_4 = true;
            }
            
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            mem[317] = chestType;
            WordForest.WFOGameEcon val_2 = WordForest.WFOGameEcon.Instance;
            mem[321] = 18.Item[chestType];
            mem[325] = 0;
        }
        private void Init()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(this != 0)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  353908288, bit:  1)) != false)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            WordForest.WFOGameEcon val_5 = WordForest.WFOGameEcon.Instance;
            if((val_3 + 328) > 5761501)
            {
                    WordForest.WFOPlayer val_6 = WordForest.WFOPlayer.Instance;
                if((MonoExtensions.IsBitSet(value:  213844506, bit:  9)) != false)
            {
                    R4.InitNewRandomData();
                return;
            }
            
            }
            
            this.InitNewData(chestType:  1);
        }
        public void IncrementWord()
        {
        
        }
        public System.Collections.Generic.List<WordForest.WFORewardData> OpenChest()
        {
        
        }
        public WFOWordChestManager()
        {
        
        }
    
    }

}
