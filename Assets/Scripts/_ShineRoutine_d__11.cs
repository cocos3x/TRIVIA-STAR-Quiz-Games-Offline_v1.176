using UnityEngine;
private sealed class HintReminderAnimation.<ShineRoutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public HintReminderAnimation <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HintReminderAnimation.<ShineRoutine>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        UnityEngine.UI.Image val_2;
        if((this.<>1__state) == 2)
        {
            goto label_0;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_1 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_1;
        }
        
        this.<>1__state = 0;
        val_1 = 1;
        this.<>4__this.shineImage.enabled = true;
        val_2 = this.<>4__this.shineImage;
        val_2.CrossFadeAlpha(alpha:  null, duration:  null, ignoreTimeScale:  false);
        this.<>1__state = val_1;
        this.<>2__current = this.<>4__this.transitionTime;
        return (bool)val_1;
        label_0:
        this.<>1__state = 0;
        val_1 = 0;
        this.<>4__this.shineImage.enabled = false;
        return (bool)val_1;
        label_1:
        this.<>1__state = 0;
        val_2 = this.<>4__this.shineImage;
        val_1 = 1;
        val_2.CrossFadeAlpha(alpha:  null, duration:  null, ignoreTimeScale:  false);
        this.<>1__state = 2;
        this.<>2__current = this.<>4__this.transitionTime;
        return (bool)val_1;
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
