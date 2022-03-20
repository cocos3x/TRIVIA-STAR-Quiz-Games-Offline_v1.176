using UnityEngine;
private sealed class WGEventProgressFlyInAwayPopup.<ShowPopup>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventProgressFlyInAwayPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGEventProgressFlyInAwayPopup.<ShowPopup>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.<>4__this.currentEventProgressPopupData = 2621443;
        this.<>4__this.eventsProgressPopupData.RemoveAt(index:  0);
        this.<>4__this.SetUpUI();
        System.Collections.IEnumerator val_1 = this.<>4__this.PlayFallAnimation();
        UnityEngine.Coroutine val_2 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        val_6 = 1;
        this.<>1__state = val_6;
        this.<>2__current = this.<>4__this;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this.currentEventProgressPopupData.onCLose) != 0)
        {
                this.<>4__this.currentEventProgressPopupData.onCLose.Invoke();
        }
        
        if((this.<>4__this.currentEventProgressPopupData.onCLose) < 1)
        {
            goto label_15;
        }
        
        System.Collections.IEnumerator val_3 = this.<>4__this.ShowPopup();
        val_6 = 0;
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        return (bool)val_6;
        label_2:
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_5 = null;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_6 = 1;
        this.<>1__state = 2;
        this.<>2__current = val_5;
        return (bool)val_6;
        label_15:
        this.<>4__this.Close();
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
