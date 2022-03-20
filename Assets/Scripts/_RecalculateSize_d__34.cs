using UnityEngine;
private sealed class Pan.<RecalculateSize>d__34 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Pan <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Pan.<RecalculateSize>d__34(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        float val_5;
        float val_6;
        int val_12;
        object val_13;
        Pan val_14;
        var val_15;
        UnityEngine.Transform val_16;
        if((this.<>1__state) != 1)
        {
                val_12 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_12;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_1 = null;
            val_13 = val_1;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            val_12 = 1;
            this.<>1__state = val_12;
            this.<>2__current = val_13;
            return (bool)val_12;
        }
        
        val_14 = this.<>4__this;
        this.<>1__state = 0;
        val_15 = 0;
        goto label_4;
        label_15:
        val_16 = this.<>4__this.centerPoint;
        if(0 <= val_15)
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + 0;
        var val_2 = val_13 + 16;
        if(val_16 == 0)
        {
            goto label_7;
        }
        
        if(null != null)
        {
                if(val_16 == 0)
        {
            goto label_11;
        }
        
        }
        
        if(null == null)
        {
            goto label_10;
        }
        
        goto label_11;
        label_7:
        label_11:
        val_16 = 0;
        label_10:
        UnityEngine.Vector3 val_3 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = mem[((0 + 0) + 16) + (0)], z = mem[((0 + 0) + 16) + (4)]});
        this.<>4__this.letterPositions.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
        val_15 = 1;
        val_14 = val_14;
        label_4:
        if(val_15 < (this.<>4__this + 16 + 12))
        {
            goto label_15;
        }
        
        LineDrawer.instance.letterPositions = this.<>4__this + 20;
        object val_7 = val_14.GetComponent<System.Object>();
        UnityEngine.Rect val_8 = rect;
        float val_9 = height;
        GameBehavior val_10 = App.getBehavior;
        uint val_14 = 2224499112;
        val_14 = val_14 / 0;
        val_12 = 0;
        UnityEngine.Transform val_11 = this.<>4__this + 40.transform;
        UnityEngine.Vector3 val_12 = new UnityEngine.Vector3(x:  0, y:  val_8.m_YMin, z:  val_8.m_Width);
        this.<>4__this + 40.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        return (bool)val_12;
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
