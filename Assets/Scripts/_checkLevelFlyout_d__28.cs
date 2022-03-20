using UnityEngine;
private sealed class TRVGameplayUI.<checkLevelFlyout>d__28 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVGameplayUI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVGameplayUI.<checkLevelFlyout>d__28(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        object val_11;
        int val_12;
        val_10 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool)val_10;
        }
        
        var val_1 = 8054356 + (8054356 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                val_10 = 0;
            val_10 = val_10 & (((int)IP) >> 3);
            val_10 = val_10 & ((R8) << 4);
            val_10 = val_10 & (((((val_10 & ((int)IP) >> 3) & (R8) << 4)) << (32-4)) | ((((val_10 & ((int)IP) >> 3) & (R8) << 4)) << 4));
        }
        
        this.<>1__state = 0;
        Player val_2 = App.Player;
        if(0 == 1)
        {
                if((CPlayerPrefs.GetBool(key:  -519482416, defaultValue:  false)) == false)
        {
            goto label_8;
        }
        
        }
        
        val_11 = 0;
        Player val_4 = App.Player;
        val_12 = 3;
        if(0 == 11)
        {
                val_11 = 0;
            if((CPlayerPrefs.GetBool(key:  -519482320, defaultValue:  false)) != true)
        {
                string val_6 = Localization.Localize(key:  -519482016, defaultValue:  -519482224, useSingularKey:  false);
            System.Collections.IEnumerator val_7 = this.<>4__this.myFlyout.DisplayFlyout(text:  -519482016, seconds:  null);
            val_11 = this.<>4__this.myFlyout;
            val_12 = 2;
        }
        
        }
        
        label_26:
        val_10 = 1;
        this.<>2__current = ;
        this.<>1__state = ;
        return (bool)val_10;
        label_8:
        string val_8 = Localization.Localize(key:  -519477520, defaultValue:  -519477808, useSingularKey:  false);
        System.Collections.IEnumerator val_9 = this.<>4__this.myFlyout.DisplayFlyout(text:  -519477520, seconds:  null);
        goto label_26;
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
