using UnityEngine;
private sealed class TRVProgressiveIAPProgressPopup.<AnimateGiftOpening>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVProgressiveIAPProgressPopup <>4__this;
    private TRVProgressiveIAPProgressPopup.<>c__DisplayClass17_0 <>8__1;
    private int <bonusAmount>5__2;
    private int <prevBonus>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVProgressiveIAPProgressPopup.<AnimateGiftOpening>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.UI.Button val_39;
        int val_40;
        if((this.<>1__state) <= 5)
        {
                var val_1 = 11968196 + (11968196 + (this.<>1__state) << 2);
            if((this.<>1__state) == 5)
        {
                11968196 + (this.<>1__state) << 2 = (11968196 + (this.<>1__state) << 2) & ((R8) << 11968196 + (this.<>1__state) << 2);
            mem2[0] = (11968196 + (this.<>1__state) << 2 & (R8) << 11968196 + (this.<>1__state) << 2) + this;
            ((11968196 + (this.<>1__state) << 2 & (R8) << 11968196 + (this.<>1__state) << 2) + this) & ((IP) >> 3) = (((11968196 + (this.<>1__state) << 2 & (R8) << 11968196 + (this.<>1__state) << 2) + this) & ((IP) >> 3)) & (((int)IP) >> 5);
            ((11968196 + (this.<>1__state) << 2 & (R8) << 11968196 + (this.<>1__state) << 2) + this) & ((IP) >> 3) = (((11968196 + (this.<>1__state) << 2 & (R8) << 11968196 + (this.<>1__state) << 2) + this) & ((IP) >> 3)) & (((int)R8) >> this);
            ((11968196 + (this.<>1__state) << 2 & (R8) << 11968196 + (this.<>1__state) << 2) + this) & ((IP) >> 3) = (((11968196 + (this.<>1__state) << 2 & (R8) << 11968196 + (this.<>1__state) << 2) + this) & ((IP) >> 3)) & ((((11968196 + (this.<>1__state) << 2 & (R8) << 11968196 + (this.<>1__state) << 2) + this) & ((IP) >> 3)) >> 10);
        }
        
            this.<>1__state = 0;
            this.<>8__1 = new System.Object();
            typeof(TRVProgressiveIAPProgressPopup.<>c__DisplayClass17_0).__il2cppRuntimeField_C = this.<>4__this;
            val_39 = this.<>4__this.openGiftButton;
            val_40 = 0;
            val_39.interactable = false;
            if((this.<>4__this.hasGiftOpened) == true)
        {
                return (bool);
        }
        
            twelvegigs.Autopilot.WUTAutopilotGameplay val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.<>4__this.giftClosed);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.giftClosed, endValue:  null, duration:  null);
            UnityEngine.WaitForSeconds val_5 = null;
            val_39 = val_5;
            val_5 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_40 = 1;
            this.<>1__state = val_40;
            this.<>2__current = val_39;
            return (bool);
        }
        
        val_40 = 0;
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
