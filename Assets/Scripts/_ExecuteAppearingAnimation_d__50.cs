using UnityEngine;
private sealed class WGChapterClearPopup.<ExecuteAppearingAnimation>d__50 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.CanvasGroup cg;
    public WGChapterClearPopup <>4__this;
    private float <f>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGChapterClearPopup.<ExecuteAppearingAnimation>d__50(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        float val_4;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            val_4 = 0f;
            this.<f>5__2 = 0f;
            this.<>1__state = 0;
        }
        else
        {
                float val_3 = this.<f>5__2;
            this.<>1__state = 0;
            float val_1 = UnityEngine.Time.deltaTime;
            val_3 = val_3 + 0;
            this.<f>5__2 = val_3;
            if((this.<>1__state) > 1)
        {
                this.<>4__this.animDone = true;
            val_3 = 0;
            return (bool)val_3;
        }
        
        }
        
        float val_4 = 5f;
        val_4 = val_4 * val_4;
        this.cg.alpha = UnityEngine.Mathf.Lerp(a:  val_4, b:  null, t:  null);
        val_3 = 1;
        this.<>1__state = val_3;
        this.<>2__current = 0;
        return (bool)val_3;
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
