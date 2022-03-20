using UnityEngine;
private sealed class DebugMessageDisplay.<FadeCanvasCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float duration;
    public DebugMessageDisplay <>4__this;
    public float from;
    public float to;
    private float <t>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DebugMessageDisplay.<FadeCanvasCoroutine>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        DebugMessageDisplay val_4;
        int val_5;
        float val_6;
        float val_7;
        UnityEngine.CanvasGroup val_8;
        float val_9;
        val_4 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            val_6 = this;
            this.<t>5__2 = 0f;
            val_7 = 0f;
            this.<>1__state = 0;
        }
        else
        {
                this.<>1__state = 0;
            if((this.<>1__state) >= 0)
        {
                val_8 = this.<>4__this.canvasGroup;
            val_5 = 0;
            val_8.alpha = 1f;
            if(val_8 >= 0)
        {
                return (bool)val_5;
        }
        
            val_5 = 0;
            UnityEngine.GameObject val_1 = this.<>4__this.canvasGroup.gameObject;
            this.<>4__this.canvasGroup.SetActive(value:  false);
            return (bool)val_5;
        }
        
            val_6 = this.<t>5__2;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        float val_4 = this.duration;
        val_4 = 0 / val_4;
        val_9 = (this.<t>5__2) + val_4;
        this.<t>5__2 = val_9;
        if(val_4 == 0)
        {
                val_9 = mem[this.<t>5__2];
            val_9 = val_6;
        }
        
        val_4 = 0;
        val_8 = this.from;
        this.<>4__this.canvasGroup.alpha = UnityEngine.Mathf.Lerp(a:  val_4, b:  null, t:  0);
        val_5 = 1;
        this.<>1__state = val_5;
        this.<>2__current = val_4;
        return (bool)val_5;
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
