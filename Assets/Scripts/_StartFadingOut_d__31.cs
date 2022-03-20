using UnityEngine;
private sealed class TRVPowerupButton.<StartFadingOut>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVPowerupButton <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVPowerupButton.<StartFadingOut>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        val_5 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            if((this.<>4__this.startedGlow) != false)
        {
                object val_1 = this.<>4__this.glow.GetComponent<System.Object>();
            this.<>4__this.glow.Stop();
        }
        
            UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
            object val_3 = this.<>4__this.GetComponent<System.Object>();
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this, endValue:  null, duration:  null);
            val_6 = 1;
            val_5 = 1;
            this.<>2__current = 0;
        }
        else
        {
                val_6 = 0;
        }
        
        this.<>1__state = val_6;
        return (bool)val_5;
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
