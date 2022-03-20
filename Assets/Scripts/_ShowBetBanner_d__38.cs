using UnityEngine;
private sealed class RESSpinInfoController.<ShowBetBanner>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESSpinInfoController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESSpinInfoController.<ShowBetBanner>d__38(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_17 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_17;
        }
        
            this.<>1__state = 0;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_3 = SpinBet.ToString();
            string val_4 = 665928704 + 665961252;
            UnityEngine.Transform val_5 = this.<>4__this.betBanner.transform;
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            this.<>4__this.betBanner.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Transform val_7 = this.<>4__this.betBanner.transform;
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.betBanner, endValue:  null, duration:  null);
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.betBannerCanvasGroup, endValue:  null, duration:  null);
            val_17 = 1;
            this.<>1__state = val_17;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_17;
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_11 = this.<>4__this.betBanner.transform;
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.betBanner, endValue:  null, duration:  null);
        DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.betBannerCanvasGroup, endValue:  null, duration:  null);
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_17 = 0;
        if(SpinBet == 1)
        {
                return (bool)val_17;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_17 = 0;
        public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_1C.ShowBet();
        return (bool)val_17;
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
