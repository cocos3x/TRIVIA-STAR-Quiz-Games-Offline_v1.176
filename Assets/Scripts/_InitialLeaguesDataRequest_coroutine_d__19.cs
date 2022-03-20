using UnityEngine;
private sealed class LeaguesManager.<InitialLeaguesDataRequest_coroutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Collections.Generic.Dictionary<string, object> response;
    public SLC.Social.Leagues.LeaguesManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaguesManager.<InitialLeaguesDataRequest_coroutine>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_58;
        var val_70;
        var val_71;
        SLC.Social.Leagues.LeaguesManager val_72;
        var val_73;
        bool val_74;
        var val_75;
        SLC.Social.Leagues.LeaguesDataController val_76;
        var val_88;
        var val_89;
        var val_90;
        var val_91;
        val_70 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool)val_70;
        }
        
        val_72 = this.<>4__this;
        var val_1 = 11101528 + (11101528 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                val_70 = val_70 & 35635666;
            val_70 = val_70 & ((1152921514024814320) << R5);
            val_70 = val_70 & (val_70 >> 13);
            val_70 = val_70 & 828032752;
            11101528 + (this.<>1__state) << 2 = val_70 & 828032752;
        }
        
        this.<>1__state = 0;
        val_73 = null;
        val_73 = null;
        if(Logger.Leagues != false)
        {
                string val_2 = PrettyPrint.printJSON(obj:  this.response, types:  false, singleLineOutput:  false);
            string val_3 = 827962336 + this.response;
            UnityEngine.Debug.LogWarning(message:  827962336);
        }
        
        val_74 = true;
        this.<>4__this._InitialResponseSuccess = val_74;
        if((this.response.ContainsKey(key:  263071328)) == false)
        {
            goto label_148;
        }
        
        SLC.Social.Profile val_5 = new SLC.Social.Profile();
        object val_6 = this.response.Item[263071328];
        val_75 = 0;
        if(this.response != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                this.response = 0;
        }
        
            val_75 = this.response;
        }
        
        Decode(jasonObject:  0, sourceModel:  0);
        this.<>4__this.dataController.MyId = SLC.Social.Profile.__il2cppRuntimeField_name;
        val_76 = this.<>4__this.dataController;
        val_76.AddOrMergeKnownMember(toKnow:  440360960);
        SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
        UpdateMyProfileInfo(force:  false);
        goto label_148;
        label_133:
        if(MoveNext() == false)
        {
            goto label_128;
        }
        
        val_88 = null;
        val_88 = null;
        SLC.Social.Leagues.LeaguesManager.clubCountByTier.Add(item:  System.Int32.Parse(s:  val_58));
        goto label_133;
        label_128:
        Dispose();
        val_72 = 1152921510392296080;
        val_71 = val_72;
        val_76 = "refresh_intervals";
        val_74 = 4;
        if((this.response.ContainsKey(key:  828016448)) != false)
        {
                val_89 = 1152921510385703632;
            object val_61 = this.response.Item[828016448];
            val_72 = 1;
            if((0.ContainsKey(key:  828020656)) != false)
        {
                string val_63 = 0.Item[828020656];
            val_90 = null;
            val_90 = null;
            val_89 = 1152921510385703632;
            SLC.Social.Leagues.LeaguesManager.RefreshRequestInterval = (float)System.Math.Max(val1:  30, val2:  System.Int32.Parse(s:  null));
        }
        
            val_76 = "slow";
            if((0.ContainsKey(key:  828020736)) != false)
        {
                string val_67 = 0.Item[828020736];
            val_91 = null;
            val_91 = null;
            SLC.Social.Leagues.LeaguesManager.SlowRefreshRequestInterval = (float)System.Math.Max(val1:  50, val2:  System.Int32.Parse(s:  null));
        }
        
        }
        
        label_148:
        this.<>2__current = 0;
        val_70 = 1;
        this.<>1__state = val_74;
        return (bool)val_70;
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
