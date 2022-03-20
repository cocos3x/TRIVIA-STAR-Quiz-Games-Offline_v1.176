using UnityEngine;
private sealed class TRVLossAversionPopup.<animateStreakBreaking>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVLossAversionPopup <>4__this;
    public int preStreak;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVLossAversionPopup.<animateStreakBreaking>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_18;
        UnityEngine.UI.Image val_23;
        int val_24;
        var val_27;
        int val_29;
        var val_30;
        if((this.<>1__state) > 6)
        {
            goto label_1;
        }
        
        var val_1 = 10814828 + (10814828 + (this.<>1__state) << 2);
        if((this.<>1__state) == 6)
        {
                10814828 + (this.<>1__state) << 2 = (10814828 + (this.<>1__state) << 2) & ((IP) << 10814828 + (this.<>1__state) << 2);
            10814828 + (this.<>1__state) << 2 = (10814828 + (this.<>1__state) << 2) & ((IP) >> (10814828 + (this.<>1__state) << 2 & (IP) << 10814828 + (this.<>1__state) << 2));
            10814828 + (this.<>1__state) << 2 = (10814828 + (this.<>1__state) << 2) & 1899670312;
            10814828 + (this.<>1__state) << 2 = (10814828 + (this.<>1__state) << 2) & (-495626672);
            mem2[0] = ((((10814828 + (this.<>1__state) << 2 & (IP) << 10814828 + (this.<>1__state) << 2) & (IP) >> (10814828 + (this.<>1__state) << 2 & (IP) << 10814828 + (this.<>1__state) << 2)) & 1899670312) & -495626672 + R8;
            ((((10814828 + (this.<>1__state) << 2 & (IP) << 10814828 + (this.<>1__state) << 2) & (IP) >> (10814828 + (this.<>1__state) << 2 & (IP) << 10814828 + (this.<>1__state) << 2)) & 1899670312) & -495626672 + R8 = (((((10814828 + (this.<>1__state) << 2 & (IP) << 10814828 + (this.<>1__state) << 2) & (IP) >> (10814828 + (this.<>1__state) << 2 & (IP) << 10814828 + (this.<>1__state) << 2)) & 1899670312) & -495626672 + R8) & (-7744167);
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_2;
        }
        
        val_23 = this.<>4__this.streakImage;
        goto label_3;
        label_1:
        val_24 = 0;
        return (bool);
        label_2:
        val_23 = 52;
        label_3:
        val_23.sprite = this.<>4__this.streakSprite;
        val_27 = 1152921511033624480;
        UnityEngine.UI.LayoutElement val_16 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.streakBrokenGroup);
        this.<>4__this.streakBrokenGroup.alpha = null;
        PluginExtension.SetColorAlpha(graphic:  this.<>4__this.streakText, a:  null);
        val_30 = 0;
        decimal val_17 = System.Decimal.op_Implicit(value:  -495638724);
        this.<>4__this.streakAmountText.CountUp(endValue:  new System.Decimal() {mid = val_18}, seconds:  null);
        val_24 = 1;
        this.<>4__this.streakBrokenGroup.SetActive(value:  true);
        UnityEngine.UI.LayoutElement val_19 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.mainGroup);
        DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.mainGroup, endValue:  null, duration:  null);
        UnityEngine.WaitForSeconds val_21 = null;
        val_29 = val_21;
        val_21 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = val_24;
        this.<>2__current = val_29;
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
