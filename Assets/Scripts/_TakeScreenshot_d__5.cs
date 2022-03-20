using UnityEngine;
private sealed class WGScreenshotter.<TakeScreenshot>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGScreenshotter <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGScreenshotter.<TakeScreenshot>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        int val_22;
        object val_23;
        UnityEngine.Texture2D val_24;
        var val_25;
        val_22 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_22;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_1 = null;
            val_23 = val_1;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            val_22 = 1;
            this.<>1__state = val_22;
            this.<>2__current = val_23;
            return (bool)val_22;
        }
        
        this.<>1__state = 0;
        if(UnityEngine.Application.isEditor != false)
        {
                string val_3 = this.<>4__this.CurrentLevelLink();
            UnityEngine.Debug.LogError(message:  this.<>4__this);
        }
        else
        {
                int val_5 = UnityEngine.Screen.height;
            UnityEngine.Texture2D val_6 = null;
            val_24 = val_6;
            val_6 = new UnityEngine.Texture2D(width:  UnityEngine.Screen.width, height:  val_5, textureFormat:  3, mipChain:  false);
            if((this.<>4__this) != 0)
        {
                val_25 = this.<>4__this;
            this.<>4__this.tex = val_24;
        }
        else
        {
                val_25 = 12;
            mem[12] = val_24;
            val_24 = mem[12];
        }
        
            UnityEngine.Rect val_7 = new UnityEngine.Rect(x:  (float)val_5, y:  null, width:  null, height:  null);
            ReadPixels(source:  new UnityEngine.Rect() {m_XMin = val_7.m_XMin, m_YMin = val_7.m_YMin, m_Width = val_7.m_Width, m_Height = val_7.m_Height}, destX:  0, destY:  0);
            Apply();
            string val_8 = UnityEngine.Application.persistentDataPath;
            System.DateTime val_9 = System.DateTime.Now;
            string val_12 = val_10.ToString(format:  45740512);
            string val_13 = 45756680 + 1975550080;
            string val_14 = System.IO.Path.Combine(path1:  null, path2:  45756680);
            System.Byte[] val_15 = UnityEngine.ImageConversion.EncodeToPNG(tex:  154206208);
            System.IO.File.WriteAllBytes(path:  null, bytes:  154206208);
            TrackingComponent.CurrentIntent = 7;
            AppConfigs val_16 = App.Configuration;
            string val_17 = Replace(oldValue:  1297836560, newValue:  System.String.alignConst);
            string val_18 = System.String.Format(format:  -12048896, arg0:  1577093456);
            GameBehavior val_19 = App.getBehavior;
            string val_20 = System.String.Format(format:  154206208, arg0:  -12048896);
            val_23 = mem[12];
            TrackingComponent.CurrentIntent = 7;
            string val_21 = this.<>4__this.CurrentLevelLink();
            twelvegigs.plugins.SharePlugin.Share(text:  154206208, url:  this.<>4__this, subject:  154206208, emailBody:  1098586544, imgPath:  0);
        }
        
        val_22 = 0;
        if((this.<>4__this.OnScreenshotTaken) == 0)
        {
                return (bool)val_22;
        }
        
        this.<>4__this.OnScreenshotTaken.Invoke();
        return (bool)val_22;
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
