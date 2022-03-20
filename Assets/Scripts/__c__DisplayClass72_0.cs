using UnityEngine;
private sealed class LeaguesDataController.<>c__DisplayClass72_0
{
    // Fields
    public System.Action<bool, string> OnMessagerResponse;
    public string message;
    public SLC.Social.Leagues.LeaguesDataController <>4__this;
    
    // Methods
    public LeaguesDataController.<>c__DisplayClass72_0()
    {
    
    }
    internal void <SendChatMessage>b__0(System.Collections.Generic.Dictionary<string, object> responseObject)
    {
        var val_3;
        var val_4;
        val_3 = 35635607;
        if(this.OnMessagerResponse != 0)
        {
                this.OnMessagerResponse.Invoke(arg1:  true, arg2:  this.message);
        }
        
        SLC.Social.Leagues.Guild val_1 = this.<>4__this.MyGuild;
        object val_2 = responseObject.Item[812964736];
        val_4 = 0;
        if(responseObject != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                responseObject = 0;
        }
        
            val_4 = responseObject;
        }
        
        this.<>4__this.MergeChat(toParse:  0);
        SLC.Social.Leagues.LeaguesTracker.AddToChatMessageCount();
    }
    internal void <SendChatMessage>b__1(string apiCall)
    {
        if(this.OnMessagerResponse == 0)
        {
                return;
        }
        
        this.OnMessagerResponse.Invoke(arg1:  false, arg2:  this.message);
    }

}
