using UnityEngine;
private sealed class RaidAttackManager.<>c__DisplayClass45_0
{
    // Fields
    public WordForest.RaidAttackManager <>4__this;
    public System.Action onInitialized;
    
    // Methods
    public RaidAttackManager.<>c__DisplayClass45_0()
    {
    
    }
    internal void <InitializeRaid>b__0(System.Collections.Generic.Dictionary<string, object> resp)
    {
        RaidAttackManager.<>c__DisplayClass45_0 val_14;
        float val_15;
        var val_16;
        WordForest.RaidAttackManager val_17;
        string val_18;
        var val_19;
        val_14 = this;
        val_15 = 1152921510392296080;
        if((resp.ContainsKey(key:  -1202791792)) == false)
        {
            goto label_20;
        }
        
        object val_2 = resp.Item[-1202791792];
        val_16 = 1;
        if((0.ContainsKey(key:  1624646480)) != false)
        {
                val_17 = this.<>4__this;
            string val_4 = 0.Item[1624646480];
            val_18 = 0;
            this.<>4__this.currentRaidId = val_18;
        }
        
        if((0.ContainsKey(key:  255995984)) != false)
        {
                WordForest.UserForestProfile val_6 = null;
            val_18 = val_6;
            val_6 = new WordForest.UserForestProfile();
            string val_7 = 0.Item[255995984];
            if(0 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
        }
        
            this.<>4__this.dataController.AddOrUpdateServerProfileToCache(profile:  404684800);
        }
        
        if((0.ContainsKey(key:  256004288)) == false)
        {
            goto label_20;
        }
        
        string val_9 = 0.Item[256004288];
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        val_15 = 0;
        System.String[] val_10 = 0.Split(separator:  478563824);
        val_18 = 0;
        System.Collections.Generic.List<System.Int32> val_11 = new System.Collections.Generic.List<System.Int32>();
        val_17 = 16;
        val_19 = 0;
        goto label_26;
        label_31:
        if((System.Int32.TryParse(s:  2621443, result: out  int val_12 = 256016344)) != false)
        {
                Add(item:  0);
        }
        
        val_19 = 1;
        label_26:
        if(val_19 < 0)
        {
            goto label_31;
        }
        
        val_14 = val_14;
        this.<>4__this.<currentRaidPickerOptions>k__BackingField = null;
        label_20:
        if(mem[1152921513452809964] == 0)
        {
                return;
        }
        
        mem[1152921513452809964].Invoke();
    }

}
