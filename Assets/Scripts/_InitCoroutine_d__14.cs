using UnityEngine;
private sealed class HorizontalRecyclingSystem.<InitCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public HorizontalRecyclingSystem <>4__this;
    public int startPos;
    public bool centered;
    public System.Action onInitialized;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HorizontalRecyclingSystem.<InitCoroutine>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_3;
        float val_4;
        float val_8;
        float val_12;
        int val_14;
        var val_15;
        object val_16;
        System.Collections.Generic.List<UnityEngine.RectTransform> val_17;
        val_14 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_14;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        val_15 = this.<>4__this;
        this.<>4__this.SetLeftAnchor(rectTransform:  null);
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_5;
        }
        
        this.<>4__this.SetRecyclingBounds();
        this.<>4__this.currentItemCount = this.startPos;
        this.<>4__this.CreateCellPool();
        this.<>4__this.leftMostCellIndex = 0;
        goto label_6;
        label_3:
        val_15 = 12;
        0.SetLeftAnchor(rectTransform:  0);
        label_4:
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = -3.355123E+15f});
        val_16 = 0;
        val_15.anchoredPosition = new UnityEngine.Vector2() {x = val_3, y = val_4};
        val_14 = 1;
        this.<>1__state = val_14;
        this.<>2__current = val_16;
        return (bool)val_14;
        label_5:
        0.SetRecyclingBounds();
        mem[92] = this.startPos;
        0.CreateCellPool();
        mem[96] = 0;
        label_6:
        val_17 = this.<>4__this._cellPool;
        if(val_17 == 0)
        {
            goto label_13;
        }
        
        this.<>4__this.rightMostCellIndex = 95;
        goto label_14;
        label_13:
        val_17 = this.<>4__this._cellPool;
        this.<>4__this.rightMostCellIndex = 95;
        if(val_17 == 0)
        {
            goto label_15;
        }
        
        label_14:
        float val_14 = (float)this.<>4__this._rows;
        val_14 = (float)val_17 / val_14;
        float val_6 = (float)val_17 * ((float)UnityEngine.Mathf.CeilToInt(f:  val_14));
        UnityEngine.Vector2 val_7 = sizeDelta;
        val_4 = 0;
        val_3 = 0;
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_7.x, y:  val_7.y);
        val_14 = 0;
        this.<>4__this._rows.sizeDelta = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        if(this.centered != false)
        {
                float val_15 = -0.5f;
            val_15 = (float)val_17 * val_15;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_15, y:  val_7.y);
            UnityEngine.Vector2 val_11 = anchoredPosition;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -3.355123E+15f, y = val_12}, b:  new UnityEngine.Vector2() {x = val_8, y = val_10.x});
            this.<>4__this._rows.anchoredPosition = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        }
        
        this.<>4__this.SetLeftAnchor(rectTransform:  this.<>4__this);
        if(this.onInitialized == 0)
        {
                return (bool)val_14;
        }
        
        val_14 = 0;
        this.onInitialized.Invoke();
        return (bool)val_14;
        label_15:
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
