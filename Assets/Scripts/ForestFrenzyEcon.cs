using UnityEngine;
public class ForestFrenzyEcon
{
    // Fields
    public static int UnlockLevel;
    public static int LevelsToPlay;
    public static int LevelsToPlayCooldownSeconds;
    public static decimal ForestCompleteReward;
    public static int[] CostPerGrowthStage;
    private static System.Collections.Generic.List<WordForest.WFOForestData> forests;
    
    // Properties
    public static System.Collections.Generic.List<WordForest.WFOForestData> Forests { get; }
    
    // Methods
    public static System.Collections.Generic.List<WordForest.WFOForestData> get_Forests()
    {
        null = null;
    }
    public static WordForest.WFOForestData GetForestEconData(int forestId)
    {
        var val_4;
        object val_1 = new System.Object();
        typeof(ForestFrenzyEcon.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = R1;
        val_4 = null;
        val_4 = null;
        System.Predicate<WordForest.WFOForestData> val_2 = new System.Predicate<WordForest.WFOForestData>(object:  316772352, method:  new IntPtr(2892323568));
        WordForest.WFOForestData val_3 = forestId.Find(match:  ForestFrenzyEcon.forests);
        return new WordForest.WFOForestData() {level = val_3.level, forestName = val_3.forestName, initialCost = val_3.initialCost, costIncrease = val_3.costIncrease};
    }
    public static WordForest.Map CreateStartingMap()
    {
        return ForestFrenzyEcon.CreateMap(forestLevel:  1, growthLevel:  0, growthPercent:  null);
    }
    public static WordForest.Map CreateMap(int forestLevel, int growthLevel = 0, float growthPercent = 0)
    {
        float val_10;
        float val_11;
        var val_12;
        System.Collections.Generic.List<WordForest.WFOForestData> val_13;
        System.Predicate<WordForest.WFOForestData> val_14;
        var val_15;
        var val_16;
        val_10 = R2;
        object val_1 = null;
        val_11 = val_1;
        val_1 = new System.Object();
        typeof(ForestFrenzyEcon.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = forestLevel;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_12 = null;
        val_12 = null;
        val_13 = ForestFrenzyEcon.forests;
        val_14 = null;
        val_14 = new System.Predicate<WordForest.WFOForestData>(object:  316825600, method:  new IntPtr(2892551664));
        int val_4 = val_13.FindIndex(match:  8040448);
        if(val_4 >= 0)
        {
                val_14 = val_4;
            val_15 = null;
            val_15 = null;
            if((ForestFrenzyEcon.forests + 12) <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_10 = ForestFrenzyEcon.forests + 8;
            val_10 = val_10 + ((val_14 + (val_14 << 1)) << 3);
            val_16 = mem[(ForestFrenzyEcon.forests + 8 + ((val_4 + (val_4) << 1)) << 3) + 32];
            val_16 = (ForestFrenzyEcon.forests + 8 + ((val_4 + (val_4) << 1)) << 3) + 32;
        }
        else
        {
                val_16 = 20;
        }
        
        if((growthLevel <= 0) && (growthLevel > 0))
        {
                float val_6 = UnityEngine.Mathf.Clamp(value:  val_10, min:  null, max:  null);
            float val_11 = 20f;
            val_11 = val_10 * val_11;
        }
        
        if(val_16 >= 1)
        {
                val_11 = 1152921505011372032;
            val_10 = 1152921511794368064;
            do
        {
            val_14 = null;
            if(0 < (UnityEngine.Mathf.FloorToInt(f:  val_11)))
        {
                0 = 1;
        }
        
            val_14 = new WordForest.MapItem(mType:  -1402413584, mId:  0, mStatus:  1);
            Add(item:  404525056);
            val_13 = 0 + 1;
        }
        while(val_16 != val_13);
        
        }
        
        WordForest.Map val_9 = new WordForest.Map(initialAreaItems:  80883712);
    }
    public ForestFrenzyEcon()
    {
    
    }
    private static ForestFrenzyEcon()
    {
        ForestFrenzyEcon.UnlockLevel = 25;
        ForestFrenzyEcon.LevelsToPlay = 5;
        ForestFrenzyEcon.LevelsToPlayCooldownSeconds = 600;
        decimal val_1 = new System.Decimal(value:  250);
        ForestFrenzyEcon.CostPerGrowthStage = null;
        System.Collections.Generic.List<WordForest.WFOForestData> val_2 = new System.Collections.Generic.List<WordForest.WFOForestData>();
        WordForest.WFOForestData val_3 = new WordForest.WFOForestData(_level:  1, _costIncrease:  30, _initialCost:  140, _name:  "forest_location_ti", _stages:  20, _bgType:  4);
        Add(item:  new WordForest.WFOForestData() {level = val_3.level, forestName = val_3.forestName, initialCost = val_3.initialCost, costIncrease = val_3.costIncrease, stages = val_3.stages, bgType = val_3.bgType});
        ForestFrenzyEcon.forests = null;
    }

}
