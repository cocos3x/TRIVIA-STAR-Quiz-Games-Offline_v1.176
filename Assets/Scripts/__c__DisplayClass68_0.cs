using UnityEngine;
private sealed class LeaguesDataController.<>c__DisplayClass68_0
{
    // Fields
    public SLC.Social.Leagues.Guild oldGuild;
    public SLC.Social.Leagues.LeaguesDataController <>4__this;
    
    // Methods
    public LeaguesDataController.<>c__DisplayClass68_0()
    {
    
    }
    internal void <JoinGuild>b__0(System.Collections.Generic.Dictionary<string, object> responseObject)
    {
        int val_3;
        SLC.Social.Leagues.Guild val_4;
        SLC.Social.Leagues.Guilds val_5;
        var val_6;
        val_3 = 35635606;
        val_4 = this.oldGuild;
        if(val_4 == 0)
        {
            goto label_1;
        }
        
        if((this.<>4__this) != 0)
        {
            goto label_2;
        }
        
        val_4 = this.oldGuild;
        if(val_4 == 0)
        {
            goto label_3;
        }
        
        label_2:
        val_5 = this.<>4__this.knownGuilds;
        val_3 = this.oldGuild.ServerId;
        bool val_1 = val_5.Remove(key:  val_3);
        label_1:
        object val_2 = responseObject.Item[812296960];
        val_6 = 0;
        if(responseObject != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                responseObject = 0;
        }
        
            val_6 = responseObject;
        }
        
        this.<>4__this.DecodeAndAddOrMergeGuild(responseObject:  0);
        return;
        label_3:
    }

}
