using UnityEngine;
private sealed class EmojiMatchUIController.<Timer>d__35 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.EmojiMatch.EmojiMatchUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EmojiMatchUIController.<Timer>d__35(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_9;
        var val_10;
        UnityEngine.UI.Slider val_11;
        float val_12;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        val_9 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool);
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) < 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        UnityEngine.GameObject val_2 = this.<>4__this.FTUXHand.gameObject;
        val_10 = this.<>4__this.FTUXHand;
        val_9 = false;
        val_10.SetActive(value:  false);
        if((this.<>4__this.firstSession) == false)
        {
            goto label_12;
        }
        
        this.<>4__this.firstSession = val_9;
        return (bool);
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_14;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_11 = this.<>4__this.timerSlider;
        this.<>4__this.timerDurationToWait = this.<>4__this.timerDurationToWait;
        goto label_15;
        label_2:
        this.<>1__state = 0;
        return (bool);
        label_14:
        val_10 = 100;
        float val_4 = UnityEngine.Time.deltaTime;
        mem[100] = 9.343217E-38f;
        val_11 = 52;
        val_12 = mem[100];
        label_15:
        val_11.normalizedValue = val_12 / (this.<>4__this.timerFullDuration);
        label_12:
        if(val_11 <= 0)
        {
                val_9 = 0;
            this.<>4__this.timerSlider.normalizedValue = this.<>4__this.timerDurationToWait;
            this.<>4__this.blockInput = true;
            this.<>4__this.OnFailure();
            return (bool);
        }
        
        val_9 = 1;
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
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
