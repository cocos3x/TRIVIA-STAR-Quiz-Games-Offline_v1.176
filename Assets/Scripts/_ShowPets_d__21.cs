using UnityEngine;
private sealed class WPTLevelClear.<ShowPets>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WPTLevelClear <>4__this;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTLevelClear.<ShowPets>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        int val_8;
        var val_9;
        object val_10;
        val_7 = 0;
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
                return (bool)val_7;
        }
        
        val_8 = 0;
        val_9 = this;
        this.<i>5__2 = val_8;
        this.<>1__state = 0;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        return (bool)val_7;
        label_2:
        val_9 = this;
        val_8 = (this.<i>5__2) + 1;
        this.<>1__state = 0;
        this.<i>5__2 = val_8;
        label_4:
        if(val_8 < (this.<i>5__2))
        {
                if((this.<i>5__2) <= (this.<i>5__2))
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_6 = val_6 + ((this.<i>5__2) << 2);
            val_9 = 0;
            UnityEngine.Transform val_1 = (0 + ((this.<i>5__2 + 1)) << 2) + 16.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  (0 + ((this.<i>5__2 + 1)) << 2) + 16, endValue:  new UnityEngine.Vector3(), duration:  val_2.x);
            UnityEngine.WaitForSeconds val_4 = null;
            val_10 = val_4;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  val_2.x);
            val_7 = 1;
            this.<>1__state = val_7;
        }
        else
        {
                UnityEngine.WaitForSeconds val_5 = null;
            val_10 = val_5;
            val_5 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>1__state = 2;
            val_7 = 1;
        }
        
        this.<>2__current = val_10;
        return (bool)val_7;
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
