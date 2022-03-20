using UnityEngine;
private sealed class RESRestaurantUI.<ShowWelcomeFTUXPopup>d__50 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESRestaurantUI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESRestaurantUI.<ShowWelcomeFTUXPopup>d__50(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        object val_9;
        var val_10;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_8 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
        this.<>1__state = 0;
        this.<>4__this.restaurantContent.ShowItems(show:  false);
        this.<>4__this.buyBtnSmall.SetActive(value:  false);
        UnityEngine.WaitForSeconds val_1 = null;
        val_9 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_8 = 1;
        this.<>1__state = val_8;
        goto label_7;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.restaurantContent.ShowItems(show:  true);
        val_10 = 0;
        this.<>4__this.buyBtnSmall.SetActive(value:  true);
        UnityEngine.Transform val_2 = this.<>4__this.bottomUI.transform;
        if((this.<>4__this.bottomUI) != 0)
        {
                if(null != null)
        {
                this.<>4__this.bottomUI = 0;
        }
        
            val_10 = this.<>4__this.bottomUI;
        }
        
        val_8 = 0;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  0, endValue:  null, duration:  null, snapping:  false);
        DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  new IntPtr(639457888));
        object val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        return (bool)val_8;
        label_2:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowFTUX(FTUXType:  1, onComplete:  0);
        this.<>4__this.buyBtnSmall.SetActive(value:  false);
        UnityEngine.WaitForSeconds val_7 = null;
        val_9 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_8 = 1;
        this.<>1__state = 2;
        label_7:
        this.<>2__current = val_9;
        return (bool)val_8;
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
