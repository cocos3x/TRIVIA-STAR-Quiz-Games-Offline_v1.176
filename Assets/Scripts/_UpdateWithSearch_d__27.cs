using UnityEngine;
private sealed class LeaguesUIGuildListView.<UpdateWithSearch>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string term;
    public SLC.Social.Leagues.LeaguesUIGuildListView <>4__this;
    private SLC.Social.Leagues.Guild[] <matching>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaguesUIGuildListView.<UpdateWithSearch>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        int val_9;
        SLC.Social.Leagues.LeaguesUIGuildListView val_10;
        int val_11;
        var val_12;
        int val_13;
        var val_14;
        int val_15;
        var val_16;
        var val_17;
        var val_18;
        val_8 = this;
        val_9 = 0;
        val_10 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
        val_11 = 0;
        this.<>1__state = val_11;
        val_12 = 0;
        if(((System.String.IsNullOrEmpty(value:  this.term)) == true) || (this.term.m_stringLength <= 1))
        {
            goto label_5;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
        val_11 = this.term;
        val_13 = 0;
        System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_3 = GetKnownGuildsByName(queryString:  val_11);
        T[] val_4 = ToArray();
        val_14 = val_8;
        this.<i>5__3 = val_13;
        mem[1152921514055058088] = null;
        goto label_10;
        label_1:
        val_14 = val_8;
        val_13 = (this.<i>5__3) + 1;
        this.<>1__state = 0;
        this.<i>5__3 = val_13;
        label_10:
        if(val_13 >= (R5 + 12))
        {
                return (bool)val_9;
        }
        
        val_11 = this.<i>5__3;
        val_15 = val_11;
        if((this.<matching>5__2) == null)
        {
                val_15 = this.<i>5__3;
        }
        
        if((R5 + 12) <= val_15)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + (val_15 << 2);
        object val_5 = (0 + ((this.<i>5__3 + 1)) << 2) + 16.GetComponent<System.Object>();
        if(val_11 >= (this.<i>5__3))
        {
            goto label_18;
        }
        
        val_10 = this.<i>5__3;
        SLC.Social.Leagues.Guild val_8 = this.<matching>5__2[val_10];
        val_16 = this.<matching>5__2[this.<i>5__3][0].ServerId;
        val_17 = 0;
        val_18 = 1;
        goto label_23;
        label_5:
        val_8 = 1152921514053745008;
        val_9 = 0;
        return (bool)val_9;
        label_18:
        val_16 = 0;
        val_17 = 0;
        val_18 = 0;
        label_23:
        (0 + ((this.<i>5__3 + 1)) << 2) + 16.UpdateUIFromGuild(guildId:  0, rankingView:  false, showMemberCount:  false, finalSeasonRank:  0);
        val_9 = 1;
        this.<>1__state = val_9;
        this.<>2__current = 0;
        return (bool)val_9;
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
