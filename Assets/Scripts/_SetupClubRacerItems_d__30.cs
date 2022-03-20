using UnityEngine;
private sealed class LeaguesUI_MyClubDetails.<SetupClubRacerItems>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Social.Leagues.LeaguesUI_MyClubDetails <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaguesUI_MyClubDetails.<SetupClubRacerItems>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_15;
        int val_16;
        int val_17;
        float val_19;
        float val_20;
        SLC.Social.Leagues.LeaguesUI_MyClubDetails val_27;
        System.Collections.Generic.List<UnityEngine.GameObject> val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        val_27 = this.<>4__this;
        this.<>1__state = 0;
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
        if(0 == 0)
        {
                return false;
        }
        
        label_30:
        SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
        System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_4 = 0.GuildsInMyTier;
        if(0 >= 0)
        {
            goto label_10;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
        System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_6 = 0.GuildsInMyTier;
        if(0 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_29 = 0;
        val_29 = val_29 + 0;
        val_28 = mem[(0 + 0) + 16];
        val_28 = (0 + 0) + 16;
        SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
        int val_8 = 0.MyGuildServerId;
        if(val_8 <= 0)
        {
                var val_30 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_30 = val_30 + 0;
        object val_9 = (0 + 0) + 16.GetComponent<System.Object>();
        var val_31 = (0 + 0) + 16 + 44;
        val_31 = val_31 - val_8;
        int val_10 = 0 + 1;
        (0 + 0) + 16.SetupUI(avatarId:  (0 + 0) + 16 + 12, yours:  val_31 >> 5, rank:  val_10, displayTier:  (0 + 0) + 16 + 20);
        val_27 = val_27;
        if(((0 + 0) + 16) <= 0)
        {
                var val_32 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_32 = val_32 + 0;
        UnityEngine.Transform val_12 = (0 + 0) + 16.transform;
        decimal val_13 = LeaguePointsFinal;
        UnityEngine.Vector2 val_18 = GetPosInTrack(points:  new System.Decimal() {flags = val_27, hi = val_16, lo = val_17, mid = val_15});
        if(((0 + 0) + 16) == 0)
        {
            goto label_26;
        }
        
        if(((0 + 0) + 16) != null)
        {
                val_29 = 0;
        }
        
        goto label_28;
        label_10:
        val_30 = 0 + 1;
        goto label_29;
        label_26:
        val_29 = 0;
        label_28:
        val_29.anchoredPosition = new UnityEngine.Vector2() {x = val_19, y = val_20};
        val_30 = val_10;
        label_29:
        if(val_30 != 15)
        {
            goto label_30;
        }
        
        val_31 = 4;
        goto label_31;
        label_51:
        SLC.Social.Leagues.LeaguesDataController val_21 = SLC.Social.Leagues.LeaguesManager.DAO;
        System.Collections.Generic.List<SLC.Social.Leagues.Guild> val_22 = 0.GuildsInMyTier;
        val_28 = this.<>4__this.clubRacerList;
        val_29 = 0;
        if(0 <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_32 = 0;
        if(val_10 < val_29)
        {
                UnityEngine.Transform val_23 = 2621443.transform;
            val_29 = 0;
            UnityEngine.Vector3 val_24 = localPosition;
            bool val_25 = RacersOverlapping(xPosA:  val_24.x, xPosB:  val_24.y);
            if(val_25 != true)
        {
                if(val_25 <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Transform val_26 = 2621443.transform;
            UnityEngine.Vector3 val_27 = localPosition;
            val_29 = 1;
        }
        
            if( <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_32 = val_29;
        }
        
        2621443.SetActive(value:  true);
        val_31 = 5;
        label_31:
        if((val_31 - 4) < 2621443)
        {
            goto label_51;
        }
        
        return false;
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
