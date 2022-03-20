using UnityEngine;
private sealed class WGExtraChapterEventProgressPopup.<Start>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGExtraChapterEventProgressPopup <>4__this;
    private UnityEngine.RectTransform <myTransform>5__2;
    private UnityEngine.Vector2 <startPos>5__3;
    private float <progress>5__4;
    private float <timeToFall>5__5;
    private int <second>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGExtraChapterEventProgressPopup.<Start>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_10;
        float val_13;
        float val_14;
        int val_34;
        var val_35;
        object val_37;
        int val_38;
        if((this.<>1__state) > 5)
        {
            goto label_1;
        }
        
        var val_1 = 7257180 + (7257180 + (this.<>1__state) << 2);
        if((this.<>1__state) == 5)
        {
                7257180 + (this.<>1__state) << 2 = (7257180 + (this.<>1__state) << 2) & (((int)IP) >> 7257180 + (this.<>1__state) << 2);
            7257180 + (this.<>1__state) << 2 = (7257180 + (this.<>1__state) << 2) & 2607254016;
            7257180 + (this.<>1__state) << 2 = (7257180 + (this.<>1__state) << 2) & ((R8) << ((7257180 + (this.<>1__state) << 2 & ((int)IP) >> 7257180 + (this.<>1__state) << 2) & 2607254016));
            7257180 + (this.<>1__state) << 2 = (7257180 + (this.<>1__state) << 2) & ((R8) << (((7257180 + (this.<>1__state) << 2 & ((int)IP) >> 7257180 + (this.<>1__state) << 2) & 2607254016) & (R8) << ((7257180 + (this.<>1__state) << 2 & ((int)IP) >> 7257180 + (this.<>1__state) << 2) & 26072);
            7257180 + (this.<>1__state) << 2 = (7257180 + (this.<>1__state) << 2) & (((int)IP) >> R3);
            7257180 + (this.<>1__state) << 2 = (7257180 + (this.<>1__state) << 2) & ((7257180 + (this.<>1__state) << 2) >> 8);
        }
        
        this.<>1__state = 0;
        if((this.<>1__state) < 0)
        {
            goto label_2;
        }
        
        this.<>4__this.canClick = true;
        this.<second>5__6 = 0;
        goto label_31;
        label_1:
        val_34 = 0;
        return (bool)val_34;
        label_31:
        UnityEngine.WaitForSeconds val_23 = null;
        val_37 = val_23;
        val_23 = new UnityEngine.WaitForSeconds(seconds:  this.<timeToFall>5__5);
        val_38 = 4;
        goto label_41;
        label_2:
        val_35 = 0;
        float val_25 = UnityEngine.Time.deltaTime;
        uint val_37 = 0;
        val_37 = (this.<progress>5__4) + val_37;
        this.<progress>5__4 = val_37;
        UnityEngine.Vector2 val_26 = UnityEngine.Vector2.zero;
        float val_38 = this.<progress>5__4;
        val_38 = val_38 / (this.<timeToFall>5__5);
        UnityEngine.Vector2 val_27 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = -9.099054E+36f, y = mem[this.<myTransform>5__2 + (4)]}, b:  new UnityEngine.Vector2() {x = mem[this.<myTransform>5__2 + (8)], y = val_10}, t:  val_38);
        mem[this.<myTransform>5__2 + (0)].anchoredPosition = new UnityEngine.Vector2() {x = val_13, y = val_14};
        UnityEngine.WaitForEndOfFrame val_28 = null;
        val_37 = val_28;
        val_28 = new UnityEngine.WaitForEndOfFrame();
        val_38 = 3;
        label_41:
        this.<>1__state = ;
        val_34 = 1;
        this.<>2__current = ;
        return (bool)val_34;
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
