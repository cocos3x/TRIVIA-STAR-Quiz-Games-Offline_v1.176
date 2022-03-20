using UnityEngine;
private sealed class LoopScrollRect.<ScrollToCellCoroutine>d__124 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.UI.LoopScrollRect <>4__this;
    public int index;
    public float speed;
    private bool <needMoving>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoopScrollRect.<ScrollToCellCoroutine>d__124(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        UnityEngine.Vector2 val_6;
        float val_11;
        float val_14;
        float val_15;
        float val_16;
        float val_19;
        float val_28;
        float val_36;
        float val_37;
        UnityEngine.Vector2 val_39;
        var val_40;
        var val_53;
        float val_54;
        var val_55;
        float val_56;
        var val_57;
        float val_58;
        float val_59;
        var val_60;
        int val_62;
        int val_63;
        val_53 = this;
        val_55 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_55;
        }
        
        this.<needMoving>5__2 = true;
        this.<>1__state = 0;
        goto label_33;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this.m_Dragging) == true)
        {
            goto label_33;
        }
        
        if(this.index >= (this.<>4__this.itemTypeStart))
        {
            goto label_6;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        goto label_30;
        label_6:
        if(this.index >= (this.<>4__this.itemTypeEnd))
        {
            goto label_8;
        }
        
        UnityEngine.RectTransform val_2 = this.<>4__this.viewRect;
        UnityEngine.Rect val_3 = rect;
        UnityEngine.Vector2 val_4 = center;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 14455.7f, y = val_5});
        UnityEngine.RectTransform val_8 = this.<>4__this.viewRect;
        UnityEngine.Rect val_9 = rect;
        UnityEngine.Vector2 val_10 = size;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 14455.66f, y = val_11});
        UnityEngine.Bounds val_17;
        val_17 = new UnityEngine.Bounds(center:  new UnityEngine.Vector3(), size:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16});
        mem2[0] = val_17.m_Extents.y;
        mem2[0] = val_17.m_Center.x;
        UnityEngine.Bounds val_18 = GetBounds4Item(index:  this.<>4__this);
        mem2[0] = val_19;
        if((this.<>4__this.directionSign) == 1)
        {
            goto label_13;
        }
        
        if((this.<>4__this.directionSign) != 1)
        {
            goto label_14;
        }
        
        if((this.<>4__this.reverseDirection) == false)
        {
            goto label_15;
        }
        
        UnityEngine.Vector3 val_20 = val_17.m_Center.x.min;
        val_58 = val_17.m_Center.y;
        UnityEngine.Vector3 val_21 = min;
        goto label_16;
        label_8:
        float val_22 = UnityEngine.Time.deltaTime;
        float val_23 = 0 * this.speed;
        goto label_30;
        label_13:
        if((this.<>4__this.reverseDirection) == false)
        {
            goto label_18;
        }
        
        UnityEngine.Vector3 val_24 = val_17.m_Center.x.max;
        val_58 = val_17.m_Center.x;
        UnityEngine.Vector3 val_25 = max;
        goto label_19;
        label_14:
        val_59 = 0f;
        goto label_20;
        label_15:
        UnityEngine.Vector3 val_26 = val_17.m_Center.x.max;
        val_58 = val_17.m_Center.y;
        UnityEngine.Vector3 val_27 = max;
        label_16:
        val_60 = val_28;
        goto label_21;
        label_18:
        UnityEngine.Vector3 val_29 = val_17.m_Center.x.min;
        val_58 = val_17.m_Center.x;
        UnityEngine.Vector3 val_30 = min;
        label_19:
        val_60 = val_19;
        label_21:
        val_59 = val_58 - val_60;
        label_20:
        if((this.<>4__this.totalCount) < 0)
        {
            goto label_50;
        }
        
        if((this.<>4__this.totalCount) <= 0)
        {
            goto label_23;
        }
        
        if((this.<>4__this.itemTypeEnd) == (this.<>4__this.totalCount))
        {
                this.<>4__this.itemTypeEnd = this.<>4__this.reverseDirection;
        }
        
        if((this.<>4__this.itemTypeEnd) == false)
        {
            goto label_24;
        }
        
        label_23:
        if((this.<>4__this.itemTypeEnd) < 0)
        {
                if((this.<>4__this.itemTypeStart) == 0)
        {
            goto label_26;
        }
        
        }
        
        label_50:
        float val_31 = UnityEngine.Time.deltaTime;
        float val_32 = 0 * (val_18.m_Extents.y + 24);
        val_54 = 1152921504762277888;
        float val_53 = System.Math.Abs(val_59);
        mem2[0] = 0;
        label_30:
        val_56 = val_17.m_Center.x;
        val_54 = val_17.m_Center.y;
        UnityEngine.Vector2 val_34 = anchoredPosition;
        UnityEngine.Vector2 val_35 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 14455.7f, y = val_19}, b:  new UnityEngine.Vector2() {x = val_28, y = val_56});
        val_57 = 0;
        this.<>4__this.m_Content.anchoredPosition = new UnityEngine.Vector2() {x = val_36, y = val_37};
        UnityEngine.Vector2 val_38 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 14455.68f, y = this.<>4__this.m_PrevPosition}, b:  new UnityEngine.Vector2() {x = val_37, y = val_56});
        this.<>4__this.m_PrevPosition = val_39;
        mem2[0] = val_40;
        UnityEngine.Vector2 val_41 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 14455.7f, y = this.<>4__this.m_ContentStartPosition}, b:  new UnityEngine.Vector2() {x = val_37, y = val_56});
        this.<>4__this.m_ContentStartPosition = val_6;
        mem2[0] = val_36;
        label_33:
        if((val_18.m_Extents.y + 28) != 0)
        {
                val_55 = 1;
            mem2[0] = val_55;
            mem2[0] = 0;
            return (bool)val_55;
        }
        
        if((this.<>4__this) == 0)
        {
            goto label_40;
        }
        
        label_51:
        val_55 = 0;
        this.<>4__this.UpdatePrevData();
        return (bool)val_55;
        label_26:
        if((this.<>4__this.reverseDirection) == false)
        {
            goto label_50;
        }
        
        UnityEngine.Bounds val_42 = val_17.m_Center.x.GetBounds4Item(index:  this.<>4__this);
        mem2[0] = val_17.m_Center.x;
        val_62 = this.<>4__this.directionSign;
        if(val_62 != 1)
        {
            goto label_42;
        }
        
        UnityEngine.Vector3 val_43 = val_17.m_Center.x.max;
        UnityEngine.Vector3 val_44 = max;
        if(val_62 < 0)
        {
            goto label_48;
        }
        
        val_62 = this.<>4__this.directionSign;
        label_42:
        if(val_62 != 1)
        {
            goto label_50;
        }
        
        UnityEngine.Vector3 val_45 = val_17.m_Center.x.min;
        UnityEngine.Vector3 val_46 = min;
        if(val_62 <= 1)
        {
            goto label_50;
        }
        
        goto label_48;
        label_24:
        int val_47 = (this.<>4__this.totalCount) - 1;
        UnityEngine.Bounds val_48 = val_17.m_Center.x.GetBounds4Item(index:  this.<>4__this);
        mem2[0] = val_17.m_Center.x;
        val_63 = this.<>4__this.directionSign;
        if(val_63 != 1)
        {
            goto label_47;
        }
        
        UnityEngine.Vector3 val_49 = val_17.m_Center.x.min;
        UnityEngine.Vector3 val_50 = min;
        if(val_63 > 1)
        {
            goto label_48;
        }
        
        val_63 = this.<>4__this.directionSign;
        label_47:
        if(val_63 != 1)
        {
            goto label_50;
        }
        
        UnityEngine.Vector3 val_51 = val_17.m_Center.x.max;
        UnityEngine.Vector3 val_52 = max;
        if(val_63 >= 0)
        {
            goto label_50;
        }
        
        label_48:
        mem2[0] = 0;
        goto label_51;
        label_40:
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
