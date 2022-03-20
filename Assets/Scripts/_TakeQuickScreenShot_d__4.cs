using UnityEngine;
private sealed class WGScreenshotter.<TakeQuickScreenShot>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGScreenshotter <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGScreenshotter.<TakeQuickScreenShot>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        object val_9;
        UnityEngine.Texture2D val_10;
        if((this.<>1__state) != 1)
        {
                val_8 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_1 = null;
            val_9 = val_1;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            val_8 = 1;
            this.<>1__state = val_8;
            this.<>2__current = val_9;
            return (bool)val_8;
        }
        
        this.<>1__state = 0;
        UnityEngine.Texture2D val_4 = null;
        val_10 = val_4;
        val_4 = new UnityEngine.Texture2D(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, textureFormat:  3, mipChain:  false);
        if((this.<>4__this) != 0)
        {
                val_9 = this.<>4__this;
            this.<>4__this.tex = val_10;
        }
        else
        {
                val_9 = 12;
            mem[12] = val_10;
            val_10 = mem[12];
        }
        
        int val_5 = UnityEngine.Screen.width;
        UnityEngine.Rect val_7 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  null, width:  null, height:  null);
        ReadPixels(source:  new UnityEngine.Rect() {m_XMin = val_7.m_XMin, m_YMin = val_7.m_YMin, m_Width = val_7.m_Width, m_Height = val_7.m_Height}, destX:  0, destY:  0);
        val_8 = 0;
        Apply();
        if((this.<>4__this.OnScreenshotTaken) == 0)
        {
                return (bool)val_8;
        }
        
        val_8 = 0;
        this.<>4__this.OnScreenshotTaken.Invoke();
        return (bool)val_8;
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
