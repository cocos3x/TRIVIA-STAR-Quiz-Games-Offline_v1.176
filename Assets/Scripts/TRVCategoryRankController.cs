using UnityEngine;
public class TRVCategoryRankController
{
    // Methods
    public static void ProcessCategoryRank(string categoryName, TRVSubCategoryProgress subcategoryProgress)
    {
        int val_15;
        float val_16;
        int val_17;
        int val_18;
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_15 = mem[1152921512476916380];
        val_16 = 1152921512639815824;
        if(subcategoryProgress.rank == val_15.Count)
        {
                return;
        }
        
        int val_3 = subcategoryProgress.rank + 1;
        val_17 = subcategoryProgress.rankProgress + 1;
        val_18 = subcategoryProgress.rank;
        subcategoryProgress.rankProgress = val_17;
        System.TimeType val_4 = val_15.Item[val_3];
        if(val_17 == (mem[1152921512476916380] + 8))
        {
                int val_14 = subcategoryProgress.rank;
            val_17 = 0;
            val_14 = val_14 + 1;
            subcategoryProgress.rank = val_14;
            subcategoryProgress.rankProgress = val_17;
            val_16 = val_18;
            val_18 = 1152921512639816848;
            if(val_3 != val_15.Count)
        {
                System.TimeType val_7 = val_15.Item[val_16 + 2];
            val_17 = mem[mem[1152921512476916380] + 8];
            val_17 = mem[1152921512476916380] + 8;
        }
        
            GameBehavior val_8 = App.getBehavior;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_11 = GetCategoryIcon(category:  categoryName);
            System.TimeType val_12 = val_15.Item[val_3];
            val_15 = mem[mem[1152921512476916380] + 12];
            val_15 = mem[1152921512476916380] + 12;
            0.Init(categorySp:  -612557856, currentRank:  val_16, nextProgressGoal:  val_17, rewardAmount:  val_15);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.SaveProgress();
    }
    public static float GetCategoryProcess(TRVSubCategoryProgress subcategoryProgress)
    {
        int val_6;
        int val_7;
        float val_8;
        val_6 = subcategoryProgress.rank;
        val_7 = 1152921512476914864;
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(val_6 == mem[1152921512476916380].Count)
        {
                val_8 = 1f;
            return (float)val_8;
        }
        
        val_6 = subcategoryProgress.rankProgress;
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_7 = subcategoryProgress.rank;
        System.TimeType val_5 = mem[1152921512476916380].Item[val_7 + 1];
        val_8 = (float)val_6 / ((float)mem[1152921512476916380] + 8);
        return (float)val_8;
    }
    public static void CollectReward(int reward)
    {
        int val_3;
        Player val_1 = App.Player;
        decimal val_2 = System.Decimal.op_Implicit(value:  -556710216);
        0.AddCredits(amount:  new System.Decimal() {mid = val_3}, source:  "Category Rank Complete", subSource:  0, externalParams:  0, doTrack:  true);
    }
    public static bool CanRankUpCategory(string subCategory)
    {
        var val_7;
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = public static TRVQuestionOfTheDayManager MonoSingleton<TRVQuestionOfTheDayManager>::get_Instance();
        val_8 = 0;
        if(IsPlaying() == true)
        {
                return (bool)val_8;
        }
        
        val_7 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-581136352) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = public static TRVPromoCategoriesHandler MonoSingleton<TRVPromoCategoriesHandler>::get_Instance();
            if((IsActivePromo(subCategoryName:  subCategory)) == false)
        {
                val_8 = 1;
        }
        
            return (bool)val_8;
        }
        
        val_8 = 1;
        return (bool)val_8;
    }
    public TRVCategoryRankController()
    {
    
    }

}
