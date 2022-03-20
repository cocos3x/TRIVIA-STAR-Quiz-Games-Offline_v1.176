using UnityEngine;
private sealed class LeaguesUI_MyClubDetails.<UpdateRaceTrack>d__28 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Social.Leagues.LeaguesUI_MyClubDetails <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaguesUI_MyClubDetails.<UpdateRaceTrack>d__28(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_3;
        int val_4;
        if((this.<>1__state) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if(0 == 0)
        {
            goto label_4;
        }
        
        val_3 = this.<>4__this;
        System.Collections.IEnumerator val_1 = val_3.SetupClubRacerItems();
        val_4 = 2;
        goto label_5;
        label_1:
        if((this.<>1__state) == 2)
        {
                this.<>1__state = 0;
        }
        
        return false;
        label_4:
        val_3 = this.<>4__this;
        System.Collections.IEnumerator val_2 = val_3.CreateClubRacerItems();
        val_4 = 1;
        label_5:
        this.<>2__current = val_3;
        this.<>1__state = val_4;
        return true;
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
