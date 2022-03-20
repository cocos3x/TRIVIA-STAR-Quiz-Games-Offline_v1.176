using UnityEngine;
private sealed class LeaguesDataController.<>c__DisplayClass50_0
{
    // Fields
    public SLC.Social.Leagues.LeaguesDataController <>4__this;
    public System.Action<bool> resultAction;
    
    // Methods
    public LeaguesDataController.<>c__DisplayClass50_0()
    {
    
    }
    internal void <UpdateMyGuildInfo>b__0(System.Collections.Generic.Dictionary<string, object> responseObject)
    {
        var val_2;
        var val_3;
        object val_1 = responseObject.Item[812296960];
        val_2 = responseObject;
        val_3 = 0;
        if(val_2 != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_2 = 0;
        }
        
            val_3 = val_2;
        }
        
        this.<>4__this.DecodeAndAddOrMergeGuild(responseObject:  0);
        this.resultAction.Invoke(obj:  true);
    }

}
