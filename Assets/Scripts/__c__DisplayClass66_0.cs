using UnityEngine;
private sealed class LeaguesDataController.<>c__DisplayClass66_0
{
    // Fields
    public SLC.Social.Leagues.LeaguesDataController <>4__this;
    public System.Action callBack;
    
    // Methods
    public LeaguesDataController.<>c__DisplayClass66_0()
    {
    
    }
    internal void <RequestGuildsByTier>b__0(System.Collections.Generic.Dictionary<string, object> responseObject)
    {
        var val_2;
        this.<>4__this.rankedGuildsInTier.Clear();
        object val_1 = responseObject.Item[812434640];
        val_2 = 0;
        if(responseObject != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                responseObject = 0;
        }
        
            val_2 = responseObject;
        }
        
        this.<>4__this.rankedGuildsInTier.Update(guilds:  0, fromModel:  0);
        if(this.callBack == 0)
        {
                return;
        }
        
        this.callBack.Invoke();
    }

}
