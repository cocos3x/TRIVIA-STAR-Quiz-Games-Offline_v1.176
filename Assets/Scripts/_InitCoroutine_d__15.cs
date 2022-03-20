using UnityEngine;
private sealed class VerticalRecyclingSystem.<InitCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public VerticalRecyclingSystem <>4__this;
    public int m_startPos;
    public bool centered;
    public System.Action onInitialized;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VerticalRecyclingSystem.<InitCoroutine>d__15(int <>1__state)
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
        float val_7;
        float val_11;
        int val_13;
        VerticalRecyclingSystem val_14;
        object val_15;
        float val_16;
        System.Collections.Generic.List<UnityEngine.RectTransform> val_17;
        val_13 = 0;
        val_14 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_13;
        }
        
        this.<>1__state = 0;
        if(val_14 == 0)
        {
            goto label_3;
        }
        
        0.SetTopAnchor(rectTransform:  null);
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if(val_14 == 0)
        {
            goto label_5;
        }
        
        val_14.SetRecyclingBounds();
        this.<>4__this.startPos = this.m_startPos;
        this.<>4__this.currentItemCount = this.m_startPos;
        val_14.CreateCellPool();
        this.<>4__this.topMostCellIndex = 0;
        goto label_6;
        label_3:
        val_14 = 12;
        0.SetTopAnchor(rectTransform:  0);
        label_4:
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = -5.631626E+15f});
        val_15 = 0;
        val_14.anchoredPosition = new UnityEngine.Vector2() {x = val_3, y = val_4};
        val_13 = 1;
        this.<>1__state = val_13;
        this.<>2__current = val_15;
        return (bool)val_13;
        label_5:
        val_16 = 0;
        0.SetRecyclingBounds();
        mem[92] = this.m_startPos;
        mem[96] = mem[92];
        0.CreateCellPool();
        mem[100] = val_16;
        label_6:
        val_17 = this.<>4__this._cellPool;
        if(val_17 == 0)
        {
            goto label_13;
        }
        
        this.<>4__this.bottomMostCellIndex = 99;
        goto label_14;
        label_13:
        val_17 = this.<>4__this._cellPool;
        this.<>4__this.bottomMostCellIndex = 99;
        if(val_17 == 0)
        {
            goto label_15;
        }
        
        label_14:
        float val_13 = (float)this.<>4__this._coloumns;
        val_13 = (float)val_17 / val_13;
        float val_5 = Infinityf * (float)val_13;
        UnityEngine.Vector2 val_6 = sizeDelta;
        val_4 = 0;
        val_3 = 0;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_6.x, y:  val_6.y);
        val_13 = 0;
        this.<>4__this._coloumns.sizeDelta = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        if(this.centered != false)
        {
                float val_14 = -0.5f;
            val_14 = Infinityf * val_14;
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_14, y:  val_6.y);
            UnityEngine.Vector2 val_10 = anchoredPosition;
            val_16 = val_9.x;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -5.631626E+15f, y = val_7}, b:  new UnityEngine.Vector2() {x = val_11, y = val_16});
            this.<>4__this._coloumns.anchoredPosition = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        }
        
        SetTopAnchor(rectTransform:  val_14);
        if(this.onInitialized == 0)
        {
                return (bool)val_13;
        }
        
        val_13 = 0;
        this.onInitialized.Invoke();
        return (bool)val_13;
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
