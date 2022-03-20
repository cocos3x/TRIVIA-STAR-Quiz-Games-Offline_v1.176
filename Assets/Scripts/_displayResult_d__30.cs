using UnityEngine;
private sealed class WhackUIController.<displayResult>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.Whack.WhackUIController <>4__this;
    public SLC.Minigames.Whack.WhackItem item;
    public bool won;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WhackUIController.<displayResult>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_4 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this.firstLevelThisSession = false;
        this.<>4__this.paused = true;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if(this.won != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CheckCheckpoint();
        }
        
        val_4 = 0;
        this.<>4__this.hammer.SetActive(value:  false);
        if(this.won == false)
        {
            goto label_11;
        }
        
        this.<>4__this.UIWon(item:  0);
        return (bool)val_4;
        label_3:
        mem[80] = 1;
        mem[113] = 0;
        label_4:
        this.<>4__this.setAllWackItemsClickable(clickable:  false);
        if(this.item != 0)
        {
                this.item.SetDisplayState(state:  2);
        }
        
        this.<>4__this.HammerHit(hitDude:  this.item);
        val_4 = 1;
        this.<>1__state = val_4;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return (bool)val_4;
        label_11:
        this.<>4__this.UILose(item:  this.item);
        return (bool)val_4;
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
