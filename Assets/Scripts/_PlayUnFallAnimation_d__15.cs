using UnityEngine;
private sealed class WGLevelChallengeProgressPopup.<PlayUnFallAnimation>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGLevelChallengeProgressPopup <>4__this;
    private float <time>5__2;
    private UnityEngine.RectTransform <myTransform>5__3;
    private UnityEngine.Vector2 <startPos>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGLevelChallengeProgressPopup.<PlayUnFallAnimation>d__15(int <>1__state)
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
        float val_7;
        float val_8;
        UnityEngine.Vector2 val_10;
        var val_11;
        int val_16;
        float val_17;
        UnityEngine.GameObject val_18;
        val_16 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_16;
        }
        
            val_17 = this;
            this.<time>5__2 = 0f;
            this.<>1__state = 0;
            UnityEngine.GameObject val_1 = this.<>4__this.gameObject;
            object val_2 = this.<>4__this.GetComponent<System.Object>();
            this.<myTransform>5__3 = this.<>4__this;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.up;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 4.099258E-39f, y = val_4}, d:  val_3.x);
            this.<>4__this.anchoredPosition = new UnityEngine.Vector2() {x = val_7, y = val_8};
            UnityEngine.Vector2 val_9 = anchoredPosition;
            this.<startPos>5__4 = val_10;
            mem[1152921513199718976] = val_11;
            val_18 = this.<>4__this.windowGroup;
            val_18.SetActive(value:  true);
        }
        else
        {
                val_17 = this.<time>5__2;
            this.<>1__state = 0;
        }
        
        if((this.<>1__state) >= 0)
        {
                return (bool)val_16;
        }
        
        float val_12 = UnityEngine.Time.deltaTime;
        uint val_16 = 0;
        val_16 = val_17 + val_16;
        this.<time>5__2 = val_16;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.zero;
        float val_17 = this.<time>5__2;
        val_17 = val_17 / 0.2f;
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = 4.099258E-39f, y = val_4}, b:  new UnityEngine.Vector2() {x = val_5, y = this.<startPos>5__4}, t:  val_17);
        this.<myTransform>5__3.anchoredPosition = new UnityEngine.Vector2() {x = val_7, y = val_8};
        UnityEngine.WaitForEndOfFrame val_15 = null;
        val_18 = val_15;
        val_15 = new UnityEngine.WaitForEndOfFrame();
        val_16 = 1;
        this.<>1__state = val_16;
        this.<>2__current = val_18;
        return (bool)val_16;
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
