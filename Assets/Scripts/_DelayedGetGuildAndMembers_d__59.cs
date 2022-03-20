using UnityEngine;
private sealed class LeaguesDataController.<DelayedGetGuildAndMembers>d__59 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Social.Leagues.LeaguesDataController <>4__this;
    public System.Collections.Generic.Dictionary<string, object> responseObject;
    private int <guildId>5__2;
    private SLC.Social.Leagues.Guild <guild>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaguesDataController.<DelayedGetGuildAndMembers>d__59(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_20;
        object val_22;
        int val_23;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 11059220 + (11059220 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                11059220 + (this.<>1__state) << 2 = (11059220 + (this.<>1__state) << 2) & ((11059220 + (this.<>1__state) << 2) << (11059220 + (this.<>1__state) << 2));
            11059220 + (this.<>1__state) << 2 = (11059220 + (this.<>1__state) << 2) * 11059220;
            11059220 + (this.<>1__state) << 2 = (11059220 + (this.<>1__state) << 2) & ((11059220 + (this.<>1__state) << 2) >> 5);
        }
        
            this.<>1__state = 0;
            object val_2 = this.responseObject.Item[812296960];
            val_20 = 0;
            if(this.responseObject != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                this.responseObject = 0;
        }
        
            val_20 = this.responseObject;
        }
        
            this.<>4__this.DecodeAndAddOrMergeGuild(responseObject:  0);
            UnityEngine.WaitForEndOfFrame val_3 = null;
            val_22 = val_3;
            val_3 = new UnityEngine.WaitForEndOfFrame();
            val_23 = 1;
            this.<>1__state = val_23;
            this.<>2__current = val_22;
            return (bool);
        }
        
        val_23 = 0;
        return (bool);
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
