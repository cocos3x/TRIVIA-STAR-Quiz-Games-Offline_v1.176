using UnityEngine;
private sealed class WGMegaHintController.<CoolMegaHint>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool tutorial;
    public System.Collections.Generic.List<LineWord> availableLines;
    public WGMegaHintController <>4__this;
    private System.Collections.Generic.List<Cell> <chosenCells>5__2;
    private System.Collections.Generic.List<Cell> <lineWordCells>5__3;
    private System.Collections.Generic.List<UnityEngine.GameObject> <tutorialRays>5__4;
    private int <hint>5__5;
    private System.Collections.Generic.List.Enumerator<Cell> <>7__wrap5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGMegaHintController.<CoolMegaHint>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        int val_38;
        WGMegaHintController val_39;
        System.Collections.Generic.List<Cell> val_40;
        int val_41;
        object val_46;
        int val_47;
        val_38 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool)val_38;
        }
        
        val_39 = this.<>4__this;
        var val_1 = 8499448 + (8499448 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                8499448 + (this.<>1__state) << 2 = (8499448 + (this.<>1__state) << 2) & (35630524 << (8499448 + (this.<>1__state) << 2));
            8499448 + (this.<>1__state) << 2 = (8499448 + (this.<>1__state) << 2) & ((8499448 + (this.<>1__state) << 2) << 4);
            8499448 + (this.<>1__state) << 2 = (8499448 + (this.<>1__state) << 2) & (-2143029833);
            mem2[0] = (((8499448 + (this.<>1__state) << 2 & (35630524) << 8499448 + (this.<>1__state) << 2) & ((8499448 + (this.<>1__state) << 2 & (35630524) << 8499448 + (this.<>1__state) << 2)) << 4) & -2143029833) + (((8499448 + (this.<>1__state) << 2 & (35630524) << 8499448 + (this.<>1__state) << 2) & ((8499448 + (this.<>1__state) << 2 & (35630524) << 8499448 + (this.<>1__state) << 2)) << 4) & -2143029833);
        }
        
        this.<>1__state = 0;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = null;
        val_40 = 1152921511118218768;
        val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.<chosenCells>5__2 = val_2;
        this.<lineWordCells>5__3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.<tutorialRays>5__4 = 0;
        if(this.tutorial != false)
        {
                this.<tutorialRays>5__4 = null;
        }
        
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) == 0)
        {
            goto label_4;
        }
        
        val_41 = this.<>4__this.numMegaHints;
        goto label_6;
        label_17:
        if((public static ScreenOverlay MonoSingleton<ScreenOverlay>::get_Instance()) < 1)
        {
            goto label_90;
        }
        
        if((public static ScreenOverlay MonoSingleton<ScreenOverlay>::get_Instance()) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_6 = this.<tutorialRays>5__4.Remove(item:  2621443);
        UnityEngine.Object.Destroy(obj:  2621443);
        goto label_17;
        label_6:
        this.<hint>5__5 = ;
        if(( < 1) || ( == 0))
        {
            goto label_82;
        }
        
        UnityEngine.WaitForEndOfFrame val_31 = null;
        val_46 = val_31;
        val_31 = new UnityEngine.WaitForEndOfFrame();
        val_38 = 1;
        this.<>1__state = val_38;
        goto label_83;
        label_82:
        if(this.tutorial == false)
        {
            goto label_84;
        }
        
        UnityEngine.WaitForSeconds val_32 = null;
        val_46 = val_32;
        val_32 = new UnityEngine.WaitForSeconds(seconds:  val_27.x);
        val_47 = 2;
        goto label_85;
        label_84:
        List.Enumerator<T> val_33 = GetEnumerator();
        this.<>1__state = 2;
        if((this.<>7__wrap5.MoveNext()) != false)
        {
                System.Collections.IEnumerator val_35 = val_39.CellAnimation(chosenCell:  this.<>7__wrap5);
            val_38 = 1;
            this.<>1__state = 3;
            this.<>2__current = val_39;
            return (bool)val_38;
        }
        
        this.<>m__Finally1();
        if(this.tutorial == false)
        {
            goto label_90;
        }
        
        UnityEngine.WaitForSeconds val_36 = null;
        val_46 = val_36;
        val_36 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_47 = 4;
        label_85:
        this.<>1__state = val_47;
        val_38 = 1;
        label_83:
        this.<>2__current = val_46;
        return (bool)val_38;
        label_90:
        this.<>4__this.canHint = true;
        WordRegion val_37 = WordRegion.instance;
        mem[72] = 1;
        label_4:
        val_38 = 0;
        return (bool)val_38;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap5.Dispose();
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
