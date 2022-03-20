using UnityEngine;
private sealed class WordRegion.<DoLevelCompleteActions>d__85 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordRegion <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordRegion.<DoLevelCompleteActions>d__85(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        object val_8;
        GameLevel val_9;
        GameLevel val_10;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_7 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_8 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 1;
        this.<>1__state = val_7;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_5;
        }
        
        0.ClearLevelProgress();
        val_9 = this.<>4__this.gameLevel;
        goto label_6;
        label_2:
        this.<>1__state = 0;
        MainController val_2 = MainController.instance;
        if((this.<>4__this) != 0)
        {
                val_10 = this.<>4__this.gameLevel;
        }
        else
        {
                val_10 = 4;
        }
        
        this.<>4__this.NotifyBeforeLevelComplete(level:  4);
        System.Func<System.Boolean> val_3 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(2240731472));
        UnityEngine.WaitUntil val_4 = null;
        val_8 = val_4;
        val_4 = new UnityEngine.WaitUntil(predicate:  7667712);
        val_7 = 1;
        this.<>1__state = 2;
        label_4:
        this.<>2__current = val_8;
        return (bool)val_7;
        label_5:
        0.ClearLevelProgress();
        val_9 = 4;
        label_6:
        this.<>4__this.NotifyLevelComplete(level:  4);
        MainController val_5 = MainController.instance;
        if((UnityEngine.Object.op_Implicit(exists:  this.<>4__this.compliment)) == false)
        {
                return (bool)val_7;
        }
        
        if((this.<>4__this.compliment.displayText) < 6)
        {
                return (bool)val_7;
        }
        
        this.<>4__this.compliment.ShowRandom();
        return (bool)val_7;
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
