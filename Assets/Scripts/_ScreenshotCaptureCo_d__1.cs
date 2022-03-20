using UnityEngine;
private sealed class BugReportScreenshotUtil.<ScreenshotCaptureCo>d__1 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BugReportScreenshotUtil.<ScreenshotCaptureCo>d__1(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        object val_10;
        if((this.<>1__state) != 1)
        {
                val_9 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
            this.<>1__state = 0;
            if(SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData != null)
        {
                UnityEngine.Debug.LogWarning(message:  493698704);
        }
        
            UnityEngine.WaitForEndOfFrame val_1 = null;
            val_10 = val_1;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            val_9 = 1;
            this.<>1__state = val_9;
            this.<>2__current = val_10;
            return (bool)val_9;
        }
        
        this.<>1__state = 0;
        val_10 = UnityEngine.Screen.height;
        int val_5 = UnityEngine.Screen.width;
        UnityEngine.Rect val_7 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  null, width:  null, height:  null);
        ReadPixels(source:  new UnityEngine.Rect() {m_XMin = val_7.m_XMin, m_YMin = val_7.m_YMin, m_Width = val_7.m_Width, m_Height = val_7.m_Height}, destX:  0, destY:  0);
        val_9 = 0;
        Apply();
        System.Byte[] val_8 = UnityEngine.ImageConversion.EncodeToPNG(tex:  154206208);
        SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData = new UnityEngine.Texture2D(width:  UnityEngine.Screen.width, height:  val_10, textureFormat:  3, mipChain:  false);
        UnityEngine.Object.Destroy(obj:  154206208);
        return (bool)val_9;
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
