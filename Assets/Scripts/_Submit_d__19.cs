using UnityEngine;
private sealed class BugReportApi.<Submit>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SRDebugger.Internal.BugReportApi <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BugReportApi.<Submit>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_16;
        var val_17;
        var val_18;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_16 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_16;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this._isBusy) == true)
        {
            goto label_4;
        }
        
        this.<>4__this._isBusy = true;
        this.<>4__this.<ErrorMessage>k__BackingField = "";
        this.<>4__this.<IsComplete>k__BackingField = false;
        this.<>4__this.<WasSuccessful>k__BackingField = false;
        this.<>4__this._www = false;
        string val_1 = SRDebugger.Internal.BugReportApi.BuildJsonRequest(report:  this.<>4__this._bugReport);
        System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        set_Item(key:  1466178816, value:  492734208);
        set_Item(key:  492734320, value:  492734208);
        set_Item(key:  492734400, value:  1466316848);
        set_Item(key:  492738576, value:  this.<>4__this._apiKey);
        UnityEngine.WWW val_4 = new UnityEngine.WWW(url:  492738672, postData:  null, headers:  78753792);
        this.<>4__this._www = null;
        label_38:
        if(null == 0)
        {
            goto label_10;
        }
        
        val_16 = 1;
        this.<>1__state = val_16;
        this.<>2__current = null;
        return (bool)val_16;
        label_1:
        this.<>1__state = 0;
        string val_5 = this.<>4__this._www.error;
        if((System.String.IsNullOrEmpty(value:  this.<>4__this._www)) == false)
        {
            goto label_15;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_7 = this.<>4__this._www.responseHeaders;
        if((this.<>4__this._www.ContainsKey(key:  492747024)) == false)
        {
            goto label_17;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_9 = this.<>4__this._www.responseHeaders;
        string val_10 = this.<>4__this._www.Item[492747024];
        val_16 = 0;
        if((this.<>4__this._www.Contains(value:  -1469356528)) == false)
        {
            goto label_21;
        }
        
        val_17 = 1;
        goto label_22;
        label_15:
        val_16 = 0;
        string val_12 = this.<>4__this._www.error;
        label_25:
        this.<>4__this.<ErrorMessage>k__BackingField = this.<>4__this._www;
        goto label_23;
        label_17:
        this.<>4__this.<ErrorMessage>k__BackingField = "Completion State Unknown";
        label_10:
        val_16 = 0;
        label_23:
        val_17 = 0;
        label_22:
        this.<>4__this.SetCompletionState(wasSuccessful:  false);
        return (bool)val_16;
        label_21:
        string val_13 = this.<>4__this._www.text;
        string val_14 = SRDebugger.Internal.SRDebugApiUtil.ParseErrorResponse(response:  this.<>4__this._www, fallback:  this.<>4__this._www);
        goto label_25;
        label_4:
        System.InvalidOperationException val_15 = new System.InvalidOperationException(message:  492755440);
        val_18 = null;
        if((System.Boolean BugReportApi.<Submit>d__19::MoveNext()) != 1)
        {
            goto label_35;
        }
        
        if(null == 0)
        {
            goto label_36;
        }
        
        typeof(System.InvalidOperationException).__il2cppRuntimeField_1C = null;
        goto label_38;
        label_36:
        mem[4] = null;
        val_18 = 4;
        label_35:
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
