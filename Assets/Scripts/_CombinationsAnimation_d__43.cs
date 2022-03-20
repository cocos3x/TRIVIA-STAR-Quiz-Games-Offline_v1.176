using UnityEngine;
private sealed class BingoEventPopup.<CombinationsAnimation>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BingoEventPopup <>4__this;
    private System.Collections.Generic.List.Enumerator<System.Collections.Generic.List<UnityEngine.Vector2Int>> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BingoEventPopup.<CombinationsAnimation>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 3)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        int val_15;
        object val_16;
        List.Enumerator<System.Collections.Generic.List<UnityEngine.Vector2Int>> val_17;
        var val_18;
        val_15 = 0;
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
                return (bool)val_15;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_16 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_15 = 1;
        this.<>1__state = val_15;
        goto label_4;
        label_2:
        this.<>1__state = 0;
        goto label_12;
        label_1:
        val_17 = this.<>7__wrap1;
        this.<>1__state = 2;
        goto label_6;
        label_12:
        List.Enumerator<T> val_2 = GetEnumerator();
        this.<>1__state = 2;
        label_6:
        if((this.<>7__wrap1.MoveNext()) == true)
        {
            goto label_11;
        }
        
        this.<>m__Finally1();
        goto label_12;
        label_11:
        val_18 = 0;
        goto label_13;
        label_21:
        BingoCell val_15 = this.<>4__this.bingoCells[val_18];
        UnityEngine.GameObject val_4 = this.<>4__this.bingoCells[0x0][0].highlightBG.gameObject;
        this.<>4__this.bingoCells[0x0][0].highlightBG.SetActive(value:  false);
        val_18 = 1;
        label_13:
        if(val_18 < (this.<>4__this.bingoCells[0x0][0].highlightBG))
        {
            goto label_21;
        }
        
        List.Enumerator<T> val_5 = GetEnumerator();
        label_29:
        if(val_15.MoveNext() == false)
        {
            goto label_23;
        }
        
        var val_16 = val_15.y;
        val_16 = val_15.x + (val_16 + (val_16 << 2));
        BingoCell val_17 = this.<>4__this.bingoCells[val_16];
        UnityEngine.GameObject val_11 = this.<>4__this.bingoCells[(val_9 + (val_8 + (val_8) << 2))][0].highlightBG.gameObject;
        this.<>4__this.bingoCells[(val_9 + (val_8 + (val_8) << 2))][0].highlightBG.SetActive(value:  true);
        PluginExtension.SetColorAlpha(graphic:  this.<>4__this.bingoCells[(val_9 + (val_8 + (val_8) << 2))][0].highlightBG, a:  null);
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.bingoCells[(val_9 + (val_8 + (val_8) << 2))][0].highlightBG, endValue:  null, duration:  null);
        object val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.bingoCells[(val_9 + (val_8 + (val_8) << 2))][0].highlightBG, ease:  4);
        goto label_29;
        label_23:
        val_15.Dispose();
        UnityEngine.WaitForSeconds val_14 = null;
        val_16 = val_14;
        val_14 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = 2;
        val_15 = 1;
        label_4:
        this.<>2__current = val_16;
        return (bool)val_15;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Dispose();
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
