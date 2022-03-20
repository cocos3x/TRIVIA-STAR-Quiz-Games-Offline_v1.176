using UnityEngine;
private sealed class LeaguesUI_MyClubDetails.<CreateClubRacerItems>d__29 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Social.Leagues.LeaguesUI_MyClubDetails <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaguesUI_MyClubDetails.<CreateClubRacerItems>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        this.<>1__state = 0;
        var val_5 = 15;
        do
        {
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this.clubRacer);
            UnityEngine.Transform val_2 = this.<>4__this.clubRacer.transform;
            this.<>4__this.clubRacer.SetParent(parent:  this.<>4__this.raceTrack, worldPositionStays:  false);
            UnityEngine.GameObject val_3 = this.<>4__this.raceTrack.gameObject;
            this.<>4__this.clubRacer.layer = this.<>4__this.raceTrack.layer;
            this.<>4__this.clubRacerList.Add(item:  this.<>4__this.clubRacer);
            val_5 = val_5 - 1;
        }
        while((this.<>4__this.clubRacerList) != 0);
        
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
