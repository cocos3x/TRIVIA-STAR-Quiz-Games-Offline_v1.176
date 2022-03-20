using UnityEngine;
private sealed class WGFreeHintPopup.<SetStrkeOutLinePos_coroutine>d__51 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGFreeHintPopup <>4__this;
    public string textToStrike;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGFreeHintPopup.<SetStrkeOutLinePos_coroutine>d__51(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_11;
        float val_12;
        float val_15;
        float val_20;
        float val_21;
        var val_22;
        float val_24;
        float val_25;
        float val_26;
        int val_27;
        object val_28;
        if((this.<>1__state) != 1)
        {
                val_27 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_27;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_1 = null;
            val_28 = val_1;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            val_27 = 1;
            this.<>1__state = val_27;
            this.<>2__current = val_28;
            return (bool)val_27;
        }
        
        this.<>1__state = 0;
        string val_2 = this.<>4__this.desc_text.Replace(oldValue:  1297836560, newValue:  1098586544);
        UnityEngine.TextGenerator val_4 = this.<>4__this.desc_text.cachedTextGenerator;
        UnityEngine.UIVertex[] val_5 = this.<>4__this.desc_text.GetVerticesArray();
        UnityEngine.Canvas val_6 = this.<>4__this.desc_text.canvas;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = -3.819126E+37f, y = 3.673424E-39f, z = 1.401298E-45f}, d:  this.<>4__this.desc_text.scaleFactor);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.back;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.819122E+37f}, b:  new UnityEngine.Vector3() {y = val_12, z = val_11});
        this.<>4__this.strikeoutLine.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_15, y = val_12, z = val_11});
        int val_27 = this.textToStrike.m_stringLength;
        val_27 = (((this.<>4__this.desc_text.IndexOf(value:  this.textToStrike)) << 2) | 2) + (val_27 << 2);
        int val_17 = val_27 - 4;
        val_27 = 0;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = -3.819119E+37f, y = 0f, z = 0f}, d:  val_14.x);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.back;
        val_28 = val_22;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.819113E+37f}, b:  new UnityEngine.Vector3() {y = val_21, z = val_20});
        this.<>4__this + 124.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26});
        return (bool)val_27;
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
