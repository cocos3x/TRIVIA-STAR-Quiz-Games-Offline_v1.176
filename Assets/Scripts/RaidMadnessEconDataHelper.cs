using UnityEngine;
public class RaidMadnessEconDataHelper
{
    // Methods
    public static RaidMadnessRewardData ParseCSV()
    {
        var val_1;
        var val_1 = 27458255;
        val_1 = 8167532 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(App.game != 18)
        {
                return RaidMadnessEconDataHelper.ParseCSV_RRV();
        }
        
        return RaidMadnessEconDataHelper.ParseCSV_WFO();
    }
    private static RaidMadnessRewardData ParseCSV_RRV()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        float val_19;
        var val_20;
        var val_25;
        UnityEngine.Texture val_1 = WGResources.Load<UnityEngine.Texture>(fileName:  -661933056, extension:  -663337856, errorLog:  true);
        string val_2 = text;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        val_15 = 0;
        System.String[] val_3 = Split(separator:  478563824);
        object val_4 = new System.Object();
        val_16 = null;
        typeof(RaidMadnessRewardData).__il2cppRuntimeField_8 = val_16;
        typeof(RaidMadnessRewardData).__il2cppRuntimeField_C = null;
        val_17 = null;
        val_18 = 0;
        var val_17 = 12;
        val_19 = 1152921504687730688;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  80883712);
        val_17 = val_17 - 1;
        var val_18 = 12;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(System.Collections.Generic.List<System.Collections.Generic.List<RESEventCoinValue>>[]).__il2cppRuntimeField_14.Add(item:  80883712);
        val_18 = val_18 - 1;
        var val_19 = 9;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<System.Collections.Generic.List<RESEventCoinValue>>[].__il2cppRuntimeField_this_arg.Add(item:  80883712);
        val_19 = val_19 - 1;
        val_20 = 4;
        var val_14 =  - 4;
        val_25 = 4;
        var val_16 =  - 4;
    }
    private static RaidMadnessRewardData ParseCSV_WFO()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        float val_14;
        var val_15;
        var val_16;
        UnityEngine.Texture val_1 = WGResources.Load<UnityEngine.Texture>(fileName:  -661933056, extension:  -663337856, errorLog:  true);
        string val_2 = text;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        val_10 = 0;
        System.String[] val_3 = Split(separator:  478563824);
        object val_4 = new System.Object();
        val_11 = null;
        typeof(RaidMadnessRewardData).__il2cppRuntimeField_8 = val_11;
        typeof(RaidMadnessRewardData).__il2cppRuntimeField_C = null;
        val_12 = null;
        val_13 = 0;
        int val_12 = 9;
        val_14 = 1152921512533454192;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  80883712);
        val_12 = val_12 - 1;
        val_15 = 4;
        var val_9 =  - 4;
        val_16 = 4;
        var val_11 =  - 4;
    }
    public RaidMadnessEconDataHelper()
    {
    
    }

}
