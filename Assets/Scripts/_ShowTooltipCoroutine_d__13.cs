using UnityEngine;
private sealed class WGDailyChallengeCalendarDisplay.<ShowTooltipCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGDailyChallengeCalendarDisplay <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGDailyChallengeCalendarDisplay.<ShowTooltipCoroutine>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_9;
        int val_10;
        var val_11;
        val_9 = this;
        if((this.<>1__state) != 1)
        {
                val_10 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_10 = 1;
            this.<>1__state = val_10;
            this.<>2__current = val_1;
            return (bool)val_10;
        }
        
        this.<>1__state = 0;
        val_10 = 0;
        WGDailyChallengeCalendarDayDisplay val_2 = this.<>4__this.ShowTooltip();
        val_9 = this.<>4__this;
        if(val_9 == 0)
        {
                return (bool)val_10;
        }
        
        System.Action val_4 = new System.Action(object:  this.<>4__this, method:  new IntPtr(2843058208));
        val_11 = null;
        val_11 = null;
        WGDailyChallengeV2Popup.onMainScreenBtnClicked = null;
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  this.<>4__this, aName:  -1450078832);
        val_10 = 0;
        UnityEngine.GameObject val_6 = this.<>4__this.tooltipButton.gameObject;
        val_9 = this.<>4__this.tooltipButton;
        val_9.SetActive(value:  true);
        System.Collections.IEnumerator val_7 = this.<>4__this.CloseTooltipCoroutine();
        UnityEngine.Coroutine val_8 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        this.<>4__this.closeTooltipCoroutine = this.<>4__this;
        return (bool)val_10;
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
