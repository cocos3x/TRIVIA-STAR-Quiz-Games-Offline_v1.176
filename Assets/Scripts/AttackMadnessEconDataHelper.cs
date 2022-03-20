using UnityEngine;
public class AttackMadnessEconDataHelper
{
    // Methods
    public static AttackMadnessRewardData ParseCSV()
    {
        var val_1;
        var val_1 = 26301347;
        val_1 = 9324440 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(App.game != 18)
        {
                return AttackMadnessEconDataHelper.ParseCSV_RRV();
        }
        
        return AttackMadnessEconDataHelper.ParseCSV_WFO();
    }
    private static AttackMadnessRewardData ParseCSV_RRV()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        float val_19;
        var val_20;
        float val_21;
        var val_25;
        UnityEngine.Texture val_1 = WGResources.Load<UnityEngine.Texture>(fileName:  -663337776, extension:  -663337856, errorLog:  true);
        string val_2 = text;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        val_15 = 0;
        System.String[] val_3 = Split(separator:  478563824);
        object val_4 = new System.Object();
        val_16 = null;
        typeof(AttackMadnessRewardData).__il2cppRuntimeField_8 = val_16;
        typeof(AttackMadnessRewardData).__il2cppRuntimeField_C = null;
        val_17 = null;
        val_18 = 0;
        var val_17 = 12;
        val_19 = 1152921512533453168;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  80883712);
        val_17 = val_17 - 1;
        var val_18 = 9;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(System.Collections.Generic.List<System.Collections.Generic.List<RESEventCoinValue>>[]).__il2cppRuntimeField_14.Add(item:  80883712);
        val_18 = val_18 - 1;
        var val_19 = 8;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<System.Collections.Generic.List<RESEventCoinValue>>[].__il2cppRuntimeField_this_arg.Add(item:  80883712);
        val_19 = val_19 - 1;
        val_20 = 4;
        val_21 = 0;
        var val_14 =  - 4;
        val_25 = 4;
        var val_16 =  - 4;
    }
    private static AttackMadnessRewardData ParseCSV_WFO()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        UnityEngine.Texture val_1 = WGResources.Load<UnityEngine.Texture>(fileName:  -663337776, extension:  -663337856, errorLog:  true);
        string val_2 = text;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        val_10 = 0;
        System.String[] val_3 = Split(separator:  478563824);
        val_11 = "GameEvents/AttackMadness/AttackMadnessEcon";
        object val_4 = new System.Object();
        val_12 = null;
        typeof(AttackMadnessRewardData).__il2cppRuntimeField_8 = val_12;
        typeof(AttackMadnessRewardData).__il2cppRuntimeField_C = null;
        val_13 = null;
        val_14 = 0;
        var val_12 = 9;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  80883712);
        val_12 = val_12 - 1;
        val_15 = 4;
        var val_9 =  - 4;
        val_16 = 4;
        var val_11 =  - 4;
    }
    public AttackMadnessEconDataHelper()
    {
    
    }

}
