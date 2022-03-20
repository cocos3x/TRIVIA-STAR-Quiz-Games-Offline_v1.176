using UnityEngine;
private sealed class Just2EmojisFTUXManager.<ShowFTUXElements>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Just2EmojisFTUXManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Just2EmojisFTUXManager.<ShowFTUXElements>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        val_6 = 1;
        this.<>1__state = val_6;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_3 = FTUXNewLetterPosition();
        if((this.<>4__this) == 0)
        {
            goto label_8;
        }
        
        this.<>4__this.ShowHand(t:  -1743617136);
        goto label_9;
        label_2:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartFTUX();
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        val_6 = 1;
        return (bool)val_6;
        label_8:
        0.ShowHand(t:  -1743617136);
        label_9:
        val_6 = 0;
        this.<>4__this.FTUXText.enabled = true;
        return (bool)val_6;
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
