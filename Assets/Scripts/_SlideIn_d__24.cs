using UnityEngine;
private sealed class RESRaidAttackFlyout.<SlideIn>d__24 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESRaidAttackFlyout <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESRaidAttackFlyout.<SlideIn>d__24(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        val_6 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            object val_1 = this.<>4__this.windowRT.GetComponent<System.Object>();
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.<>4__this.windowRT, endValue:  null, duration:  null, snapping:  this.<>4__this.anchorYMax);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.windowRT, ease:  this.<>4__this.slideInEase);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShakeScreen();
            val_7 = 1;
            val_6 = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        }
        else
        {
                val_7 = 0;
        }
        
        this.<>1__state = val_7;
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
