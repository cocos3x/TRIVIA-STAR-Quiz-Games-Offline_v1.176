using UnityEngine;
private sealed class TRVPowerupButton.<StartFadingIn>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVPowerupButton <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVPowerupButton.<StartFadingIn>d__30(int <>1__state)
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
            UnityEngine.GameObject val_1 = this.<>4__this.gameObject;
            UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this);
            this.<>4__this.alpha = null;
            UnityEngine.GameObject val_3 = this.<>4__this.gameObject;
            object val_4 = this.<>4__this.GetComponent<System.Object>();
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this, endValue:  null, duration:  null);
            this.<>4__this.CheckFTUX();
            val_7 = 1;
            val_6 = 1;
            this.<>2__current = 0;
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
