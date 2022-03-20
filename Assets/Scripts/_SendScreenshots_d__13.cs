using UnityEngine;
private sealed class AutopilotRequester.<SendScreenshots>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public twelvegigs.Autopilot.AutopilotRequester <>4__this;
    private string <actionTimestamp>5__2;
    private UnityEngine.Networking.UnityWebRequest <w>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AutopilotRequester.<SendScreenshots>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_15;
        twelvegigs.Autopilot.AutopilotRequester val_16;
        UnityEngine.Networking.UnityWebRequest val_17;
        var val_18;
        val_15 = 0;
        val_16 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_15;
        }
        
        this.<>1__state = 0;
        string val_1 = null.ToString();
        val_17;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_17;
        twelvegigs.Autopilot.AutopilotTools.LogFormat(format:  1119342240, args:  472754880);
        this.<>4__this.screenshotRunning = true;
        goto label_9;
        label_1:
        this.<>1__state = 0;
        if((this.<w>5__3.isNetworkError) != true)
        {
                if((this.<w>5__3.isHttpError) == false)
        {
            goto label_13;
        }
        
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.<actionTimestamp>5__2;
        string val_4 = this.<w>5__3.error;
        val_17 = this.<w>5__3;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_17;
        twelvegigs.Autopilot.AutopilotTools.LogErrorFormat(format:  1119358752, args:  472754880);
        goto label_22;
        label_13:
        twelvegigs.Autopilot.AutopilotTools.Log(message:  1119358912);
        label_22:
        this.<>4__this.screenshots.RemoveAt(index:  0);
        this.<actionTimestamp>5__2 = 0;
        this.<w>5__3 = 0;
        label_9:
        if((this.<>4__this.screenshots) <= 0)
        {
            goto label_26;
        }
        
        if((this.<>4__this.screenshots) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_5 = 2621443.Item[1117859312];
        this.<actionTimestamp>5__2 = 2621443;
        string val_6 = 2621443.Item[1117859424];
        string val_7 = 2621443.Item[-233819456];
        UnityEngine.WWWForm val_8 = null;
        val_17 = val_8;
        val_8 = new UnityEngine.WWWForm();
        AddField(fieldName:  1117859312, value:  this.<actionTimestamp>5__2);
        twelvegigs.Autopilot.AutopilotRequester val_15 = val_16;
        val_15 = val_15 + 40;
        string val_9 = val_15.ToString();
        if(val_17 == 0)
        {
            goto label_36;
        }
        
        AddField(fieldName:  -1459821264, value:  val_15);
        AddField(fieldName:  1117859424, value:  2621443);
        AddField(fieldName:  -233819456, value:  2621443);
        goto label_37;
        label_26:
        val_15 = false;
        this.<>4__this.screenshotRunning = val_15;
        return (bool)val_15;
        label_36:
        AddField(fieldName:  -1459821264, value:  val_15);
        AddField(fieldName:  1117859424, value:  2621443);
        AddField(fieldName:  -233819456, value:  2621443);
        label_37:
        AddField(fieldName:  2112633200, value:  -1821882608);
        string val_10 = 2621443.Item[1117859520];
        val_16 = 2621443;
        val_18 = 0;
        string val_11 = this.<actionTimestamp>5__2(this.<actionTimestamp>5__2) + 1975550080;
        if(val_16 != 0)
        {
                val_18 = val_16;
            if(val_16 == 0)
        {
                val_18 = 0;
        }
        
        }
        
        AddBinaryData(fieldName:  1119379504, contents:  null, fileName:  this.<actionTimestamp>5__2, mimeType:  "image/png");
        UnityEngine.Networking.UnityWebRequest val_12 = UnityEngine.Networking.UnityWebRequest.Post(uri:  this.<>4__this + 16, formData:  175824896);
        this.<w>5__3 = this.<>4__this + 16;
        UnityEngine.Networking.CertificateHandler val_13 = new UnityEngine.Networking.CertificateHandler();
        this.<>4__this + 16.certificateHandler = 457986048;
        UnityEngine.Networking.UnityWebRequestAsyncOperation val_14 = this.<w>5__3.SendWebRequest();
        val_15 = 1;
        this.<>1__state = val_15;
        this.<>2__current = this.<w>5__3;
        return (bool)val_15;
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
